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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB1080", Offset = "0x7CAF680", VA = "0x187CB1080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CAB470", Offset = "0x7CA9A70", VA = "0x187CAB470", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB46F0", Offset = "0x7CB2CF0", VA = "0x187CB46F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JEPHHFGMCHL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CA26F0", Offset = "0x7CA0CF0", VA = "0x187CA26F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CAF280", Offset = "0x7CAD880", VA = "0x187CAF280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF4C0", Offset = "0x7CADAC0", VA = "0x187CAF4C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C97190", Offset = "0x7C95790", VA = "0x187C97190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C973A0", Offset = "0x7C959A0", VA = "0x187C973A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	[UnityEngine.Scripting.Preserve]
	public KPDMCICBJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4B70", Offset = "0x7CA3170", VA = "0x187CA4B70", Slot = "4")]
	[AsyncStateMachine(typeof(MLHEFPCIOMH))]
	public Task<IReadOnlyList<CCDAHBCPCKI>> MJLFCHJNIMI(long FFFLOIOFAMB, long GHFFAIKCNFL, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4A60", Offset = "0x7CA3060", VA = "0x187CA4A60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB1630", Offset = "0x7CAFC30", VA = "0x187CB1630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB1AF0", Offset = "0x7CB00F0", VA = "0x187CB1AF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x279AED0", Offset = "0x27994D0", VA = "0x18279AED0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PLBDHHLPCDB? HJPCGMLBGAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1060540", Offset = "0x105EB40", VA = "0x181060540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PIKIEAEJGHF? HHOAOADHCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x279A070", Offset = "0x2798670", VA = "0x18279A070", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NPLFGADMADE DDHDAKKKAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "10")]
			get
			{
				return default(NPLFGADMADE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D990", Offset = "0x7C9BF90", VA = "0x187C9D990", Slot = "9")]
		[AsyncStateMachine(typeof(ODLPMPGJMEL))]
		public Task<GGLMIDJEDGD> JIMJEDANMDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DA90", Offset = "0x7C9C090", VA = "0x187C9DA90")]
		public FJADBLGECOG(int MBIBLBLAFLH, DBEECBAIEKP LFKMDFJLHHG, CCDAHBCPCKI MEPGDKHHEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D7A0", Offset = "0x7C9BDA0", VA = "0x187C9D7A0", Slot = "11")]
		public bool Equals(ILOGHKFFJCK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D830", Offset = "0x7C9BE30", VA = "0x187C9D830", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D8D0", Offset = "0x7C9BED0", VA = "0x187C9D8D0")]
		private bool FHDOMOHKHIL(FJADBLGECOG OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D910", Offset = "0x7C9BF10", VA = "0x187C9D910", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C9CDE0", Offset = "0x7C9B3E0", VA = "0x187C9CDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C9D030", Offset = "0x7C9B630", VA = "0x187C9D030", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CA0980", Offset = "0x7C9EF80", VA = "0x187CA0980", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DBEECBAIEKP IOIIIAMPFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7CA09C0", Offset = "0x7C9EFC0", VA = "0x187CA09C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime CIFKOFNMDFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7CA0C00", Offset = "0x7C9F200", VA = "0x187CA0C00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PLBDHHLPCDB? HJPCGMLBGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7CA0E10", Offset = "0x7C9F410", VA = "0x187CA0E10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PIKIEAEJGHF? HHOAOADHCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7CA0DC0", Offset = "0x7C9F3C0", VA = "0x187CA0DC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NPLFGADMADE DDHDAKKKAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6D0", Offset = "0xA6DCD0", VA = "0x180A6F6D0", Slot = "10")]
			get
			{
				return default(NPLFGADMADE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C05BF0", Offset = "0x1C041F0", VA = "0x181C05BF0")]
		public GPADFBDCLKL(JICNBBCNCAC HNGPDEBEPAB, PLBDHHLPCDB HNCPOCNKKJK, PIKIEAEJGHF PFCGBJNJLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0CD0", Offset = "0x7C9F2D0", VA = "0x187CA0CD0", Slot = "9")]
		[AsyncStateMachine(typeof(DJCDNLAJIMP))]
		public Task<GGLMIDJEDGD> JIMJEDANMDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0B00", Offset = "0x7C9F100", VA = "0x187CA0B00", Slot = "11")]
		public bool Equals(ILOGHKFFJCK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0A50", Offset = "0x7C9F050", VA = "0x187CA0A50", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0BA0", Offset = "0x7C9F1A0", VA = "0x187CA0BA0")]
		private bool FHDOMOHKHIL(GPADFBDCLKL OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0C50", Offset = "0x7C9F250", VA = "0x187CA0C50", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C96CD0", Offset = "0x7C952D0", VA = "0x187C96CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C96F30", Offset = "0x7C95530", VA = "0x187C96F30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CAF530", Offset = "0x7CADB30", VA = "0x187CAF530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime CIFKOFNMDFI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PLBDHHLPCDB? HJPCGMLBGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7CAF8D0", Offset = "0x7CADED0", VA = "0x187CAF8D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public PIKIEAEJGHF? HHOAOADHCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7CAF880", Offset = "0x7CADE80", VA = "0x187CAF880", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NPLFGADMADE DDHDAKKKAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "10")]
			get
			{
				return default(NPLFGADMADE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1C05BF0", Offset = "0x1C041F0", VA = "0x181C05BF0")]
		public MNHGHGLFJBJ(DBEECBAIEKP LFKMDFJLHHG, PLBDHHLPCDB HNCPOCNKKJK, PIKIEAEJGHF PFCGBJNJLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF7B0", Offset = "0x7CADDB0", VA = "0x187CAF7B0", Slot = "9")]
		[AsyncStateMachine(typeof(AFDHMPACOGO))]
		public Task<GGLMIDJEDGD> JIMJEDANMDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF550", Offset = "0x7CADB50", VA = "0x187CAF550", Slot = "11")]
		public bool Equals(ILOGHKFFJCK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF5C0", Offset = "0x7CADBC0", VA = "0x187CAF5C0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF720", Offset = "0x7CADD20", VA = "0x187CAF720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF640", Offset = "0x7CADC40", VA = "0x187CAF640")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C99160", Offset = "0x7C97760", VA = "0x187C99160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C99FA0", Offset = "0x7C985A0", VA = "0x187C99FA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C985B0", Offset = "0x7C96BB0", VA = "0x187C985B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C98FB0", Offset = "0x7C975B0", VA = "0x187C98FB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CB1500", Offset = "0x7CAFB00", VA = "0x187CB1500")]
	[UnityEngine.Scripting.Preserve]
	public ODBKAOCMIJK([IBJCGEMJMJL(null)] JBDOFFKILIO GKGBKHAIAFK, [IBJCGEMJMJL(null)] GBKJFIMCMFN GABMMHOCOPK, [IBJCGEMJMJL(null)] MLLFMMCDFHB IBOEAOHNAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1210", Offset = "0x7CAF810", VA = "0x187CB1210")]
	[AsyncStateMachine(typeof(BFMMFGPBLFE))]
	public Task<IList<ILOGHKFFJCK>> CACKNOECBDP(long FFFLOIOFAMB, long OGHBKCHPPKA, bool CFBPABAAKPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1360", Offset = "0x7CAF960", VA = "0x187CB1360")]
	private bool MOJHFBLDGMN(DateTime? AAMKJDBEGPK, long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1100", Offset = "0x7CAF700", VA = "0x187CB1100")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CB22D0", Offset = "0x7CB08D0", VA = "0x187CB22D0")]
	public ONLCNDEELLL(long HHDCJNGKHGF, long GHFFAIKCNFL, EGNAIGBOKNB BMIPLDLMPCD, [CanBeNull] Exception HINHJPOOGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2280", Offset = "0x7CB0880", VA = "0x187CB2280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CB2230", Offset = "0x7CB0830", VA = "0x187CB2230")]
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
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public MOHCECBCNBF(GDBFIEIFOFD FJKJDPBPFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF920", Offset = "0x7CADF20", VA = "0x187CAF920")]
	public MOHCECBCNBF HDNBEKIKOKN(string LKMGECEEGEE, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF9F0", Offset = "0x7CADFF0", VA = "0x187CAF9F0")]
	public bool JGLPDMLONCF([Out] IEnumerable<KeyValuePair<string, string>> DFCAGDHCENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D4F840", Offset = "0x6D4DE40", VA = "0x186D4F840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB1B60", Offset = "0x7CB0160", VA = "0x187CB1B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1DE0", Offset = "0x7CB03E0", VA = "0x187CB1DE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA20E0", Offset = "0x7CA06E0", VA = "0x187CA20E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2310", Offset = "0x7CA0910", VA = "0x187CA2310", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public BCKGCFPIBIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C98100", Offset = "0x7C96700", VA = "0x187C98100", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C98560", Offset = "0x7C96B60", VA = "0x187C98560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C984B0", Offset = "0x7C96AB0", VA = "0x187C984B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HJPHNPODALD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C984B0", Offset = "0x7C96AB0", VA = "0x187C984B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x956B10", Offset = "0x955110", VA = "0x180956B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PABAJGGCEIB OPDEEJLEAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x956CC0", Offset = "0x9552C0", VA = "0x180956CC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x956D40", Offset = "0x955340", VA = "0x180956D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x958C60", Offset = "0x957260", VA = "0x180958C60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x958C70", Offset = "0x957270", VA = "0x180958C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JBCPMCBEPKG AABBPKBJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x956D90", Offset = "0x955390", VA = "0x180956D90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x956D10", Offset = "0x955310", VA = "0x180956D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public FFGHMBJEEPI KNCHOHPEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x956D00", Offset = "0x955300", VA = "0x180956D00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x956AE0", Offset = "0x9550E0", VA = "0x180956AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public ENHCOOGKGFN IBKKPEDKHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x95C550", Offset = "0x95AB50", VA = "0x18095C550", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x95C5C0", Offset = "0x95ABC0", VA = "0x18095C5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MBLNBFNLDAN KNCLIBPLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x95C640", Offset = "0x95AC40", VA = "0x18095C640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95AAE0", VA = "0x18095C4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DPIIEOFIMOM PHPFCFNFHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ABD0", VA = "0x18095C5D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x95C500", Offset = "0x95AB00", VA = "0x18095C500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KPLLGNPEHIH BLOAHGPPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA740D0", Offset = "0xA726D0", VA = "0x180A740D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1127740", Offset = "0x1125D40", VA = "0x181127740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CIJEFFLHNAA AGMOJFIJANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x95C620", Offset = "0x95AC20", VA = "0x18095C620", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x95C600", Offset = "0x95AC00", VA = "0x18095C600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public FCMBODEBKNC OINFPFHDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB8B630", Offset = "0xB89C30", VA = "0x180B8B630", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xCEE8F0", Offset = "0xCECEF0", VA = "0x180CEE8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FCMMGHLPILA HHHIMKMGAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x955950", Offset = "0x953F50", VA = "0x180955950", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x955910", Offset = "0x953F10", VA = "0x180955910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public LCEMKOAHHCJ IOMAKCALOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xABD020", Offset = "0xABB620", VA = "0x180ABD020", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xD04D20", Offset = "0xD03320", VA = "0x180D04D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IFLFCLCHFEP KPNECHLBHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xBE34D0", Offset = "0xBE1AD0", VA = "0x180BE34D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xBE34E0", Offset = "0xBE1AE0", VA = "0x180BE34E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public MGDLBKFILKB HKGKHFNMCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB8B460", Offset = "0xB89A60", VA = "0x180B8B460", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF86160", Offset = "0xF84760", VA = "0x180F86160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PMEHDCBJAMG JCPCCAIJBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xB76760", Offset = "0xB74D60", VA = "0x180B76760", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xC12C80", Offset = "0xC11280", VA = "0x180C12C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GKBANNDJOKF BBMICFEAICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3E660", Offset = "0xA3CC60", VA = "0x180A3E660", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3E090", Offset = "0xA3C690", VA = "0x180A3E090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public AGKANHNJNLI HOLJPLDMKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9558C0", Offset = "0x953EC0", VA = "0x1809558C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x955930", Offset = "0x953F30", VA = "0x180955930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PGODPOGHOLM NIAAEALDING
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA42C40", Offset = "0xA41240", VA = "0x180A42C40", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA42590", Offset = "0xA40B90", VA = "0x180A42590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public NKMJHFBEIDI OIIIDMNDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C610", Offset = "0xA5AC10", VA = "0x180A5C610", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9D0", Offset = "0xA58FD0", VA = "0x180A5A9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public DCMMBBANFEL COMDGOENGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C700", Offset = "0xA3AD00", VA = "0x180A3C700", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC20", Offset = "0xA59220", VA = "0x180A5AC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FIJOEDODGBA BBCPFOAOKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3C830", Offset = "0xA3AE30", VA = "0x180A3C830", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA42B10", Offset = "0xA41110", VA = "0x180A42B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KAONJJMLICJ PDEAINCIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3C840", Offset = "0xA3AE40", VA = "0x180A3C840", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA38C70", Offset = "0xA37270", VA = "0x180A38C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public OICHENLNLMC HJMDJIOKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D30", Offset = "0x9C2330", VA = "0x1809C3D30", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9D0", Offset = "0x9BCFD0", VA = "0x1809BE9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DFPFMGJEMIJ NECKCCAIJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA2BBE0", Offset = "0xA2A1E0", VA = "0x180A2BBE0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x10255E0", Offset = "0x1023BE0", VA = "0x1810255E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public OBPMHPKAJAE OFABDIKCLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4D0", Offset = "0x9BAAD0", VA = "0x1809BC4D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA38230", Offset = "0xA36830", VA = "0x180A38230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public MLDPBHLIHNF LJMHJJJIELH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9B62A0", Offset = "0x9B48A0", VA = "0x1809B62A0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA62030", Offset = "0xA60630", VA = "0x180A62030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public GBKJFIMCMFN FIHFHECHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9C33F0", Offset = "0x9C19F0", VA = "0x1809C33F0", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C1A50", Offset = "0x9C0050", VA = "0x1809C1A50", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C2350", Offset = "0x9C0950", VA = "0x1809C2350", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C0E20", Offset = "0x9BF420", VA = "0x1809C0E20", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C1130", Offset = "0x9BF730", VA = "0x1809C1130", Slot = "36")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2F4C0", Offset = "0xA2DAC0", VA = "0x180A2F4C0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1207B60", Offset = "0x1206160", VA = "0x181207B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool HAKABMECDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3700", Offset = "0x7CA1D00", VA = "0x187CA3700", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool OPCKMGOAHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CA33A0", Offset = "0x7CA19A0", VA = "0x187CA33A0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private bool EHIKNBJBNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x118B440", Offset = "0x1189A40", VA = "0x18118B440", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private CancellationToken LPFEBDELAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA37C0", Offset = "0x7CA1DC0", VA = "0x187CA37C0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private GFKEMDIOCPC OIEBGAFPKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private bool CFIMGJLBHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x118B440", Offset = "0x1189A40", VA = "0x18118B440", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1183780", Offset = "0x1181D80", VA = "0x181183780", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event Action IHNOOMPNDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7CA37E0", Offset = "0x7CA1DE0", VA = "0x187CA37E0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2F70", Offset = "0x7CA1570", VA = "0x187CA2F70", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event BHFIBGOCBGD ABAAPBNKEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3760", Offset = "0x7CA1D60", VA = "0x187CA3760", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA36A0", Offset = "0x7CA1CA0", VA = "0x187CA36A0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event BHFIBGOCBGD CFMAOOPDEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3340", Offset = "0x7CA1940", VA = "0x187CA3340", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3840", Offset = "0x7CA1E40", VA = "0x187CA3840", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event BHFIBGOCBGD BMEJBIOOKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2FD0", Offset = "0x7CA15D0", VA = "0x187CA2FD0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7CA32E0", Offset = "0x7CA18E0", VA = "0x187CA32E0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1207B60", Offset = "0x1206160", VA = "0x181207B60", Slot = "39")]
	public void FNIHNPMDEGC(KLIKFJJFGJN BDEANLGMCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3A10", Offset = "0x7CA2010", VA = "0x187CA3A10")]
	[UnityEngine.Scripting.Preserve]
	internal KFMILBOLIBF([IBJCGEMJMJL(null)] GFKEMDIOCPC MGOKPJKELJG, [IBJCGEMJMJL(null)] JFIOHCKEEIP MGMCFGLJIGI, [IBJCGEMJMJL(null)] PABAJGGCEIB GKMJGJIIHAD, [IBJCGEMJMJL(null)] JJKJBCNAAJM MOKEOOADLAP, [IBJCGEMJMJL(null)] JBCPMCBEPKG PLMBJFDOPBK, [IBJCGEMJMJL(null)] FFGHMBJEEPI DPJMJJNONDI, [IBJCGEMJMJL(null)] ENHCOOGKGFN ADFGFLNPGOG, [IBJCGEMJMJL(null)] MBLNBFNLDAN CHKICNMGPAD, [IBJCGEMJMJL(null)] DPIIEOFIMOM CACFAEOIFNH, [IBJCGEMJMJL(null)] KPLLGNPEHIH PILDNBCJPBD, [IBJCGEMJMJL(null)] CIJEFFLHNAA HHONMODOICF, [IBJCGEMJMJL(null)] FCMBODEBKNC FOIFJMFNKIJ, [IBJCGEMJMJL(null)] FCMMGHLPILA HIENPDPIDMP, [IBJCGEMJMJL(null)] LCEMKOAHHCJ DNLMCJOKGEI, [IBJCGEMJMJL(null)] IFLFCLCHFEP GGFIOOHINMN, [IBJCGEMJMJL(null)] MGDLBKFILKB LNAHAONDIEH, [IBJCGEMJMJL(null)] PMEHDCBJAMG EKLKOFOKCAJ, [IBJCGEMJMJL(null)] GKBANNDJOKF EMDFGFNLMAL, [IBJCGEMJMJL(null)] AGKANHNJNLI DDMNIJNLCKC, [IBJCGEMJMJL(null)] PGODPOGHOLM LKBMJDKBGGL, [IBJCGEMJMJL(null)] DCMMBBANFEL GBHJIOELJIE, [IBJCGEMJMJL(null)] NKMJHFBEIDI FNFKCGGCBKG, [IBJCGEMJMJL(null)] FIJOEDODGBA EGBCPDEJJEK, [IBJCGEMJMJL(null)] KAONJJMLICJ EPLCNPPDIGO, [IBJCGEMJMJL(null)] OICHENLNLMC KGCLBBHLNLJ, [IBJCGEMJMJL(null)] OBPMHPKAJAE HIGIOODIHPF, [IBJCGEMJMJL(null)] MLDPBHLIHNF OOAHFJPLOHB, [IBJCGEMJMJL(null)] GBKJFIMCMFN MEDKFMLAJLB, [IBJCGEMJMJL(null)] IGEMEIBHHGN ALALDEOKAPP, [IBJCGEMJMJL(null)] EGCFGIOCDGL OAHKGNHNFGN, [IBJCGEMJMJL(null)] KOGJGNIFGMB PBOOMDNBGPL, [IBJCGEMJMJL(null)] COLHIDLGKEK OCMFPKGPGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7CA35F0", Offset = "0x7CA1BF0", VA = "0x187CA35F0")]
	private void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3140", Offset = "0x7CA1740", VA = "0x187CA3140", Slot = "57")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3420", Offset = "0x7CA1A20", VA = "0x187CA3420", Slot = "51")]
	private void GAHHLFNOMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA38A0", Offset = "0x7CA1EA0", VA = "0x187CA38A0", Slot = "52")]
	private PDOFNJJFGGG NHBMADDCCMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3470", Offset = "0x7CA1A70", VA = "0x187CA3470", Slot = "53")]
	private NNPFBKHPJCA GNMKBFFAMOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3030", Offset = "0x7CA1630", VA = "0x187CA3030", Slot = "54")]
	[AsyncStateMachine(typeof(ODMPPCMIPCF))]
	private Task<GGLMIDJEDGD> BMMDKHADEMH(JICNBBCNCAC CIIBJONMFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3500", Offset = "0x7CA1B00", VA = "0x187CA3500", Slot = "55")]
	[AsyncStateMachine(typeof(HPNDGOEOFMG))]
	private Task HEJENGLKLGG(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3930", Offset = "0x7CA1F30", VA = "0x187CA3930")]
	[IteratorStateMachine(typeof(BCKGCFPIBIL))]
	private IEnumerable<HJPHNPODALD> NNBNOMOKLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA39B0", Offset = "0x7CA1FB0", VA = "0x187CA39B0")]
	[CompilerGenerated]
	private void OHLIENFNKEE(HJPHNPODALD MEFMJJOMDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class AONEKBFECLA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x158FD30", Offset = "0x158E330", VA = "0x18158FD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB0560", Offset = "0x7CAEB60", VA = "0x187CB0560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0870", Offset = "0x7CAEE70", VA = "0x187CB0870", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9A120", Offset = "0x7C98720", VA = "0x187C9A120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public BIEKFCJMBNE(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A010", Offset = "0x7C98610", VA = "0x187C9A010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA4090", Offset = "0x7CA2690", VA = "0x187CA4090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CA49F0", Offset = "0x7CA2FF0", VA = "0x187CA49F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3FE0", Offset = "0x7CA25E0", VA = "0x187CA3FE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public KHEJEMCLCDI(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3E90", Offset = "0x7CA2490", VA = "0x187CA3E90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9AF10", Offset = "0x7C99510", VA = "0x187C9AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B900", Offset = "0x7C99F00", VA = "0x187C9B900", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB0FD0", Offset = "0x7CAF5D0", VA = "0x187CB0FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public NKPELOMOEJK(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0E80", Offset = "0x7CAF480", VA = "0x187CB0E80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BFCNMBAMPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C990E0", Offset = "0x7C976E0", VA = "0x187C990E0")]
		internal object HEEEMJFKFIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C99020", Offset = "0x7C97620", VA = "0x187C99020")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9DAF0", Offset = "0x7C9C0F0", VA = "0x187C9DAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E730", Offset = "0x7C9CD30", VA = "0x187C9E730", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9F3C0", Offset = "0x7C9D9C0", VA = "0x187C9F3C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public GENDMNDFJJB(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F270", Offset = "0x7C9D870", VA = "0x187C9F270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9D220", Offset = "0x7C9B820", VA = "0x187C9D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C9D740", Offset = "0x7C9BD40", VA = "0x187C9D740", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9D0A0", Offset = "0x7C9B6A0", VA = "0x187C9D0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public ECDIGCHBPGC(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D0F0", Offset = "0x7C9B6F0", VA = "0x187C9D0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9E880", Offset = "0x7C9CE80", VA = "0x187C9E880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9EC00", Offset = "0x7C9D200", VA = "0x187C9EC00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NHOHHGJLPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB08E0", Offset = "0x7CAEEE0", VA = "0x187CB08E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CA0FE0", Offset = "0x7C9F5E0", VA = "0x187CA0FE0")]
	[AsyncStateMachine(typeof(GBOGMBPJDFO))]
	internal static Task<GIOJEJCDGJA.KFHIANBIKAB> DGNHDDJNOJL(JJKJBCNAAJM MOKEOOADLAP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0E60", Offset = "0x7C9F460", VA = "0x187CA0E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA2F30", Offset = "0x7CA1530", VA = "0x187CA2F30")]
		public static KFHIANBIKAB FLHKLEFIOME()
		{
			return default(KFHIANBIKAB);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2F40", Offset = "0x7CA1540", VA = "0x187CA2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GFGJDPDBLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F470", Offset = "0x7C9DA70", VA = "0x187C9F470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9EC70", Offset = "0x7C9D270", VA = "0x187C9EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F200", Offset = "0x7C9D800", VA = "0x187C9F200", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA2370", Offset = "0x7CA0970", VA = "0x187CA2370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2690", Offset = "0x7CA0C90", VA = "0x187CA2690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9A6E0", Offset = "0x7C98CE0", VA = "0x187C9A6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A4B0", Offset = "0x7C98AB0", VA = "0x187C9A4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A500", Offset = "0x7C98B00", VA = "0x187C9A500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private KPLLGNPEHIH BLOAHGPPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A580", Offset = "0x7C98B80", VA = "0x187C9A580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x258B9C0", Offset = "0x2589FC0", VA = "0x18258B9C0")]
	public BILNEPDMCCP(CancellationToken LAEIHJHNGEK, CFEMEJBKCKD JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A860", Offset = "0x7C98E60", VA = "0x187C9A860")]
	public static CNLHFGLFLAC NODOHPOJJPB(CFEMEJBKCKD JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A5D0", Offset = "0x7C98BD0", VA = "0x187C9A5D0")]
	[AsyncStateMachine(typeof(GCCDKKOCDIM))]
	public Task<bool> IKIFLPOJPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A2A0", Offset = "0x7C988A0", VA = "0x187C9A2A0")]
	private bool GPANONNKHLO([Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A1D0", Offset = "0x7C987D0", VA = "0x187C9A1D0")]
	[AsyncStateMachine(typeof(JEBMDMDCDJL))]
	private Task FOEGNAFBGHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A730", Offset = "0x7C98D30", VA = "0x187C9A730")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C970C0", Offset = "0x7C956C0", VA = "0x187C970C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B9DE20", Offset = "0x4B9C420", VA = "0x184B9DE20")]
	public AHECFMBNCBG(IFLFCLCHFEP GGFIOOHINMN, Guid EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C96FA0", Offset = "0x7C955A0", VA = "0x187C96FA0")]
	public TaskAwaiter<(GGLMIDJEDGD, Task)> CHPBIIJHJCK()
	{
		return default(TaskAwaiter<(GGLMIDJEDGD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C96FF0", Offset = "0x7C955F0", VA = "0x187C96FF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB1F30", Offset = "0x7CB0530", VA = "0x187CB1F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CB20A0", Offset = "0x7CB06A0", VA = "0x187CB20A0")]
	public OJJNGLKMFBG(TimeSpan GAOGFDNIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1F70", Offset = "0x7CB0570", VA = "0x187CB1F70")]
	public void IGIAKLIKOCA(Task HALLDLPJOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1EA0", Offset = "0x7CB04A0", VA = "0x187CB1EA0")]
	public void DOCBADCHDJP(GGLMIDJEDGD DNHNCONLMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1E50", Offset = "0x7CB0450", VA = "0x187CB1E50")]
	public void DNEAFHEGGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2010", Offset = "0x7CB0610", VA = "0x187CB2010")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JKKPKJHADIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2F00", Offset = "0x7CA1500", VA = "0x187CA2F00")]
		internal bool CMDCBOOOPKM(KOLBKODMCOP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2DC0", Offset = "0x7CB13C0", VA = "0x187CB2DC0")]
	public static HLOJEJEEEIJ OILMBKHFGKP(long HHDCJNGKHGF, long GHFFAIKCNFL, string BPPPCIKOLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2940", Offset = "0x7CB0F40", VA = "0x187CB2940")]
	public static HLOJEJEEEIJ OILMBKHFGKP(long HHDCJNGKHGF, long GHFFAIKCNFL, DDDGOPGHMJC LBDLMMONJCN, long AFCAJMDPILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2C30", Offset = "0x7CB1230", VA = "0x187CB2C30")]
	public static HLOJEJEEEIJ OILMBKHFGKP(AKEHIKAMMJM IJGHHIICOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2A00", Offset = "0x7CB1000", VA = "0x187CB2A00")]
	public static HLOJEJEEEIJ OILMBKHFGKP(EPDFKONBMMJ PDFINDDHOBK, CCDAHBCPCKI OAKKOJCACFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2850", Offset = "0x7CB0E50", VA = "0x187CB2850")]
	public static HLOJEJEEEIJ GELOBFDJBHG(this HLOJEJEEEIJ GOAPBALNOKD, EPDFKONBMMJ KCMEEOGPOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB26C0", Offset = "0x7CB0CC0", VA = "0x187CB26C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA0280", Offset = "0x7C9E880", VA = "0x187CA0280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0920", Offset = "0x7C9EF20", VA = "0x187CA0920", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB2450", Offset = "0x7CB0A50", VA = "0x187CB2450", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Task PKHMDMABMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB25A0", Offset = "0x7CB0BA0", VA = "0x187CB25A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7CB22F0", Offset = "0x7CB08F0", VA = "0x187CB22F0", Slot = "6")]
	public void BDMONGODBMC(Task CBPINBDBDCO, string MHKIBDNHKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2480", Offset = "0x7CB0A80", VA = "0x187CB2480")]
	[AsyncStateMachine(typeof(GOJGDKFDKPD))]
	private Task LNGIFBKFKDA(Task JNEEHFAADNH, string MHKIBDNHKBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2630", Offset = "0x7CB0C30", VA = "0x187CB2630")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB0D50", Offset = "0x7CAF350", VA = "0x187CB0D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0BD0", Offset = "0x7CAF1D0", VA = "0x187CB0BD0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB09E0", Offset = "0x7CAEFE0", VA = "0x187CB09E0", Slot = "5")]
	public void BFIDLKAKGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0B90", Offset = "0x7CAF190", VA = "0x187CB0B90", Slot = "6")]
	public void NOJCJJMPODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0DC0", Offset = "0x7CAF3C0", VA = "0x187CB0DC0")]
	private Task LBPKNFIDCDN(BBNKNABMABP MEBAFDHEDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0B90", Offset = "0x7CAF190", VA = "0x187CB0B90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB459D0", Offset = "0xB43FD0", VA = "0x180B459D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB45120", Offset = "0xB43720", VA = "0x180B45120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x479B390", Offset = "0x4799990", VA = "0x18479B390")]
		public IPKADIADMFP(FIIDOADKEDD MGBNFJALEFB, string LKMGECEEGEE, T IDJBNLNBJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x479ACF0", Offset = "0x47992F0", VA = "0x18479ACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C948F0", Offset = "0x7C92EF0", VA = "0x187C948F0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public TimeSpan OFPFCEAELIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7C94B30", Offset = "0x7C93130", VA = "0x187C94B30", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TimeSpan LPIDEMCAIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7C94AB0", Offset = "0x7C930B0", VA = "0x187C94AB0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public TimeSpan OCMKBAODPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7C94930", Offset = "0x7C92F30", VA = "0x187C94930", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool ONNBHNKGGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7C949B0", Offset = "0x7C92FB0", VA = "0x187C949B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool BJJBIDFBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7C94A30", Offset = "0x7C93030", VA = "0x187C94A30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LGMMLPDBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7C94A70", Offset = "0x7C93070", VA = "0x187C94A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int LPGOOAMPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7C94AF0", Offset = "0x7C930F0", VA = "0x187C94AF0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NKHLDFHBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7C94970", Offset = "0x7C92F70", VA = "0x187C94970", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool POLLNJJDHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7C949F0", Offset = "0x7C92FF0", VA = "0x187C949F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7C94B70", Offset = "0x7C93170", VA = "0x187C94B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FNGJPPIGDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E7A0", Offset = "0x7C9CDA0", VA = "0x187C9E7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9C8A0", Offset = "0x7C9AEA0", VA = "0x187C9C8A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CD40", Offset = "0x7C9B340", VA = "0x187C9CD40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event BHFIBGOCBGD BGEHMJMFPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CCA0", Offset = "0x7C9B2A0", VA = "0x187C9CCA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CB30", Offset = "0x7C9B130", VA = "0x187C9CB30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event BHFIBGOCBGD FBFLJJCBJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C600", Offset = "0x7C9AC00", VA = "0x187C9C600", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CA90", Offset = "0x7C9B090", VA = "0x187C9CA90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event BHFIBGOCBGD MIMOGFPFFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C970", Offset = "0x7C9AF70", VA = "0x187C9C970", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CBD0", Offset = "0x7C9B1D0", VA = "0x187C9CBD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "17")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C6A0", Offset = "0x7C9ACA0", VA = "0x187C9C6A0", Slot = "12")]
	public void FNGFDLAHFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CC70", Offset = "0x7C9B270", VA = "0x187C9CC70", Slot = "13")]
	public void PDEEODDPKFD(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CA60", Offset = "0x7C9B060", VA = "0x187C9CA60", Slot = "14")]
	public void NDOILGLNJLL(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C940", Offset = "0x7C9AF40", VA = "0x187C9C940", Slot = "15")]
	public void HDJGIOOMCDN(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CA10", Offset = "0x7C9B010", VA = "0x187C9CA10", Slot = "16")]
	public void MCHPNIELGPN(FDFGBGCLFKC MNGFNEKIDGN, bool JHGFMOPHGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C430", Offset = "0x7C9AA30", VA = "0x187C9C430")]
	private void CNDNDIPPKBE(BHFIBGOCBGD AOGBMEDINNC, ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CA2760", Offset = "0x7CA0D60", VA = "0x187CA2760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7CA2EA0", Offset = "0x7CA14A0", VA = "0x187CA2EA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CA4D10", Offset = "0x7CA3310", VA = "0x187CA4D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7CA59C0", Offset = "0x7CA3FC0", VA = "0x187CA59C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KPJPBHHHFOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7CA4C90", Offset = "0x7CA3290", VA = "0x187CA4C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C94FE0", Offset = "0x7C935E0", VA = "0x187C94FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool MDLEBGFBHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7C961C0", Offset = "0x7C947C0", VA = "0x187C961C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7C96BB0", Offset = "0x7C951B0", VA = "0x187C96BB0")]
		public AALANMPLJKI(JJKJBCNAAJM MOKEOOADLAP, ALHPBBOBFGN BFAPGALGCNE, GDBFIEIFOFD FJKJDPBPFHP, GIOJEJCDGJA[] CBNJIAEIOOO, CancellationToken LAEIHJHNGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7C95AA0", Offset = "0x7C940A0", VA = "0x187C95AA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7C95EA0", Offset = "0x7C944A0", VA = "0x187C95EA0")]
		public void KFCPGKMLPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7C96050", Offset = "0x7C94650", VA = "0x187C96050")]
		public void LDHGAOBLLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7C95000", Offset = "0x7C93600", VA = "0x187C95000")]
		public void BPCGDAMGBAD(FCMBODEBKNC.Reason CHJLEBAOFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7C96350", Offset = "0x7C94950", VA = "0x187C96350")]
		[AsyncStateMachine(typeof(JGKAHMJGCII))]
		public Task ONHLAHEGJMH(FCMBODEBKNC.Reason CEGFAIJENKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7C95F10", Offset = "0x7C94510", VA = "0x187C95F10")]
		[AsyncStateMachine(typeof(LHJFHIEHOMD))]
		private Task<GIOJEJCDGJA.KFHIANBIKAB> KKEOMFOLBEO(FCMBODEBKNC.Reason CEGFAIJENKH, GIOJEJCDGJA IMJKKDJLCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7C95980", Offset = "0x7C93F80", VA = "0x187C95980")]
		private void DMIMHMDNCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7C95C40", Offset = "0x7C94240", VA = "0x187C95C40")]
		public bool JPHMDPFHEIJ(FCMBODEBKNC.Reason NPGMHPAKHMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7C96560", Offset = "0x7C94B60", VA = "0x187C96560")]
		private void PJOCPNJCCDE(PIKOKLKNONL CEGAGHAOIDD, FCMBODEBKNC.Reason CEGFAIJENKH = FCMBODEBKNC.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7C952D0", Offset = "0x7C938D0", VA = "0x187C952D0")]
		private void CGPLALPCAAL(PIKOKLKNONL CEGAGHAOIDD, GIOJEJCDGJA.KFHIANBIKAB BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7C95CF0", Offset = "0x7C942F0", VA = "0x187C95CF0")]
		private void KDLKIPDKNOE(PIKOKLKNONL CEGAGHAOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7C955B0", Offset = "0x7C93BB0", VA = "0x187C955B0")]
		private void DGKJPGODIOP(PIKOKLKNONL CEGAGHAOIDD, GIOJEJCDGJA.KFHIANBIKAB BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7C961E0", Offset = "0x7C947E0", VA = "0x187C961E0")]
		private void NGINHJJFJEC(PIKOKLKNONL CEGAGHAOIDD, Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7C954A0", Offset = "0x7C93AA0", VA = "0x187C954A0")]
		private void CIBKOONHIFB(GIOJEJCDGJA IMJKKDJLCAE, FCMBODEBKNC.Reason CEGFAIJENKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7C96450", Offset = "0x7C94A50", VA = "0x187C96450")]
		private void PAMKKBGIOCI(GIOJEJCDGJA IMJKKDJLCAE, FCMBODEBKNC.Reason CEGFAIJENKH, string ABJDEJGJGFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7C96820", Offset = "0x7C94E20", VA = "0x187C96820", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C94FE0", Offset = "0x7C935E0", VA = "0x187C94FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool MDLEBGFBHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x7C961C0", Offset = "0x7C947C0", VA = "0x187C961C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2E50", Offset = "0x7CB1450", VA = "0x187CB2E50")]
		public void APDCJKMBNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2FC0", Offset = "0x7CB15C0", VA = "0x187CB2FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2FE0", Offset = "0x7CB15E0", VA = "0x187CB2FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3350", Offset = "0x7CB1950", VA = "0x187CB3350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MGDBEHEKLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB810", Offset = "0x7CA9E10", VA = "0x187CAB810")]
		internal object JMPMEGGCDNN(PIKOKLKNONL x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB7A0", Offset = "0x7CA9DA0", VA = "0x187CAB7A0")]
		internal object CIFGODJMLHL(AALANMPLJKI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB880", Offset = "0x7CA9E80", VA = "0x187CAB880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CAFA80", Offset = "0x7CAE080", VA = "0x187CAFA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0500", Offset = "0x7CAEB00", VA = "0x187CB0500", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C97410", Offset = "0x7C95A10", VA = "0x187C97410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7C980A0", Offset = "0x7C966A0", VA = "0x187C980A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9A910", Offset = "0x7C98F10", VA = "0x187C9A910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AEB0", Offset = "0x7C994B0", VA = "0x187C9AEB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA1690", Offset = "0x7C9FC90", VA = "0x187CA1690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool KLILGEALKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x20F7810", Offset = "0x20F5E10", VA = "0x1820F7810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool OCFGDOIMDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA1620", Offset = "0x7C9FC20", VA = "0x187CA1620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7CA15A0", Offset = "0x7C9FBA0", VA = "0x187CA15A0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7CA14B0", Offset = "0x7C9FAB0", VA = "0x187CA14B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1210", Offset = "0x7C9F810", VA = "0x187CA1210", Slot = "9")]
	public void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA14C0", Offset = "0x7C9FAC0", VA = "0x187CA14C0")]
	private bool EHIIBKCEBOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA17D0", Offset = "0x7C9FDD0", VA = "0x187CA17D0", Slot = "6")]
	private void KAFCOFFJEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA16E0", Offset = "0x7C9FCE0", VA = "0x187CA16E0", Slot = "5")]
	[AsyncStateMachine(typeof(NAAMLONCLCB))]
	private Task JLDMGFBBPIA(FCMBODEBKNC.Reason CEGFAIJENKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA18A0", Offset = "0x7C9FEA0", VA = "0x187CA18A0")]
	private bool LEBILHAJPOO(FCMBODEBKNC.Reason CEGFAIJENKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1B80", Offset = "0x7CA0180", VA = "0x187CA1B80")]
	private GIOJEJCDGJA[] PMKCOFLMEMB(GDBFIEIFOFD HJPNCAOEOMF, ALHPBBOBFGN DBPNLAGHDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7CA13A0", Offset = "0x7C9F9A0", VA = "0x187CA13A0")]
	[AsyncStateMachine(typeof(AONFFFHAHNM))]
	private Task DJKADILNNHB(FCMBODEBKNC.Reason CEGFAIJENKH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1F50", Offset = "0x7CA0550", VA = "0x187CA1F50")]
	[AsyncStateMachine(typeof(BNLHKDOFKIA))]
	private Task PNNIOHPBCLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9B970", Offset = "0x7C99F70", VA = "0x187C9B970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C2E0", Offset = "0x7C9A8E0", VA = "0x187C9C2E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9F4C0", Offset = "0x7C9DAC0", VA = "0x187C9F4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0170", Offset = "0x7C9E770", VA = "0x187CA0170", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GNICGKPODPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CA01D0", Offset = "0x7C9E7D0", VA = "0x187CA01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PCAHLAGJIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA5A30", Offset = "0x7CA4030", VA = "0x187CA5A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CAB410", Offset = "0x7CA9A10", VA = "0x187CAB410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBF6A0", Offset = "0x7CBDCA0", VA = "0x187CBF6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0110", Offset = "0x7CBE710", VA = "0x187CC0110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB7460", Offset = "0x7CB5A60", VA = "0x187CB7460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB78E0", Offset = "0x7CB5EE0", VA = "0x187CB78E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBF160", Offset = "0x7CBD760", VA = "0x187CBF160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF630", Offset = "0x7CBDC30", VA = "0x187CBF630", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB6DB0", Offset = "0x7CB53B0", VA = "0x187CB6DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7400", Offset = "0x7CB5A00", VA = "0x187CB7400", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CMHBOPNHDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8890", Offset = "0x7CB6E90", VA = "0x187CB8890")]
		internal object FKNACOMAGNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8790", Offset = "0x7CB6D90", VA = "0x187CB8790")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC61A0", Offset = "0x7CC47A0", VA = "0x187CC61A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6D40", Offset = "0x7CC5340", VA = "0x187CC6D40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBC440", Offset = "0x7CBAA40", VA = "0x187CBC440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCC30", Offset = "0x7CBB230", VA = "0x187CBCC30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC21E0", Offset = "0x7CC07E0", VA = "0x187CC21E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CC39D0", Offset = "0x7CC1FD0", VA = "0x187CC39D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD1A50", Offset = "0x7CD0050", VA = "0x187CD1A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2240", Offset = "0x7CD0840", VA = "0x187CD2240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BLKHIAINGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A40", Offset = "0x7CB6040", VA = "0x187CB7A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EMDCIHADDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCD00", Offset = "0x7CBB300", VA = "0x187CBCD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OFMHBKOCNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0260", Offset = "0x7CCE860", VA = "0x187CD0260")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BKPPCDGKFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7940", Offset = "0x7CB5F40", VA = "0x187CB7940")]
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
		[Cpp2IlInjected.Address(RVA = "0x978C70", Offset = "0x977270", VA = "0x180978C70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x111DD00", Offset = "0x111C300", VA = "0x18111DD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7CADB20", Offset = "0x7CAC120", VA = "0x187CADB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD6B0", Offset = "0x7CABCB0", VA = "0x187CAD6B0", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC8D0", Offset = "0x7CAAED0", VA = "0x187CAC8D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7CACF90", Offset = "0x7CAB590", VA = "0x187CACF90", Slot = "5")]
	[AsyncStateMachine(typeof(CLMOONLLFKH))]
	public Task GJMCAALDLPD(GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC630", Offset = "0x7CAAC30", VA = "0x187CAC630")]
	[AsyncStateMachine(typeof(GLPLMOEPMNH))]
	private Task CPCJDAFJBFG(GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEA00", Offset = "0x7CAD000", VA = "0x187CAEA00")]
	private void PGBIONPEKIC(EGCFGIOCDGL OAHKGNHNFGN, GDBFIEIFOFD DHCIGOGFOEM, Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB8F0", Offset = "0x7CA9EF0", VA = "0x187CAB8F0")]
	private static void BMOMJNLJBDB(MOHCECBCNBF BPPGOKMFDFE, Exception DADIPHEHDBH, [Optional] List<int> OPDPAHDHGHM, int NFAPJLNFMCI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7CADBD0", Offset = "0x7CAC1D0", VA = "0x187CADBD0")]
	[AsyncStateMachine(typeof(LMGDLEMCPEC))]
	private Task IIGEGFEJFLM(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, OKCNIPGMDHK JFOKBCJFBJM, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC4B0", Offset = "0x7CAAAB0", VA = "0x187CAC4B0")]
	private void COCHAHMACBO([CallerMemberName] string GMBCKGNNDKD = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7CADDB0", Offset = "0x7CAC3B0", VA = "0x187CADDB0")]
	[AsyncStateMachine(typeof(FGNNBPCKAKP))]
	private Task IMPPNOFNGCP(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7CACC60", Offset = "0x7CAB260", VA = "0x187CACC60")]
	private void GINBJAEBCAI(GDBFIEIFOFD DHCIGOGFOEM, CancellationToken DGLOFFGGICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE550", Offset = "0x7CACB50", VA = "0x187CAE550")]
	private void NFLMFNMMNFK(GDBFIEIFOFD DHCIGOGFOEM, TaskStatus GLPBMEOEGBJ, string MIALAMIFNLM, OKCNIPGMDHK JFOKBCJFBJM, Exception BNMNAMAKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD30", Offset = "0x7CAC330", VA = "0x187CADD30")]
	private void IJHOPNHFCHF(GDBFIEIFOFD DHCIGOGFOEM, OKCNIPGMDHK JFOKBCJFBJM, OperationCanceledException ENCCBHPHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE020", Offset = "0x7CAC620", VA = "0x187CAE020")]
	private void JHJDCJDAKAG(GDBFIEIFOFD DHCIGOGFOEM, OKCNIPGMDHK JFOKBCJFBJM, Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD0D0", Offset = "0x7CAB6D0", VA = "0x187CAD0D0")]
	private void HCMNINFCOBH(GDBFIEIFOFD DHCIGOGFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE4F0", Offset = "0x7CACAF0", VA = "0x187CAE4F0")]
	private static ONLCNDEELLL LGOOHGMPOFL(GDBFIEIFOFD DHCIGOGFOEM)
	{
		return default(ONLCNDEELLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC2C0", Offset = "0x7CAA8C0", VA = "0x187CAC2C0")]
	[AsyncStateMachine(typeof(AGJKPABIPKJ))]
	private Task CAAIEFKDLLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEE70", Offset = "0x7CAD470", VA = "0x187CAEE70")]
	[AsyncStateMachine(typeof(FFMFCIGHGCK))]
	private Task<Matchmaking.PDLIEJBBEGE> PJBIIBNIDDH(GDBFIEIFOFD DHCIGOGFOEM, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE3E0", Offset = "0x7CAC9E0", VA = "0x187CAE3E0")]
	private static BGGHNMEBHJH KNENFONIEOO(Matchmaking.PDLIEJBBEGE FNMCKCCGIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE290", Offset = "0x7CAC890", VA = "0x187CAE290")]
	[AsyncStateMachine(typeof(ADDHGKPPLCK))]
	private Task KMPHLGJFGKC(Matchmaking.PDLIEJBBEGE FNMCKCCGIGM, OKCNIPGMDHK JFOKBCJFBJM, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken ENHKOFNDDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CADEE0", Offset = "0x7CAC4E0", VA = "0x187CADEE0")]
	[AsyncStateMachine(typeof(JHAKGKENHII))]
	private Task JGLACHLKHGO(GDBFIEIFOFD DHCIGOGFOEM, CancellationTokenSource BGMKNBDDENN, Task LBMJEAPJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC150", Offset = "0x7CAA750", VA = "0x187CAC150")]
	[AsyncStateMachine(typeof(EHCAJMCBLJC))]
	private Task BOLJCLGJAKB(HLOJEJEEEIJ JIPCODKNIPN, MNIAMPGIDNC FKKJJFDOIBC, GDBFIEIFOFD BHLBEBPCKLE, OKCNIPGMDHK OEPFHMOFFDK, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken FOHJLPEAOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE0A0", Offset = "0x7CAC6A0", VA = "0x187CAE0A0")]
	private OKCNIPGMDHK KAPFJOGOIFO(OKCNIPGMDHK OEPFHMOFFDK, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD9E0", Offset = "0x7CABFE0", VA = "0x187CAD9E0")]
	[AsyncStateMachine(typeof(IAAKHLGFPDG))]
	private Task IAGFPINPDED(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE8D0", Offset = "0x7CACED0", VA = "0x187CAE8D0")]
	[AsyncStateMachine(typeof(PBNJJOCPOFN))]
	private Task OFDIHHAOHIJ(CancellationToken LAEIHJHNGEK, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD2E0", Offset = "0x7CAB8E0", VA = "0x187CAD2E0")]
	private static void HDACGMPKBDJ(GDBFIEIFOFD DHCIGOGFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD460", Offset = "0x7CABA60", VA = "0x187CAD460")]
	private void HJGHOBODNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CACA20", Offset = "0x7CAB020", VA = "0x187CACA20")]
	private void EIHAEGJDIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC420", Offset = "0x7CAAA20", VA = "0x187CAC420")]
	private void CCBFOIJCILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC390", Offset = "0x7CAA990", VA = "0x187CAC390")]
	private void CAEACMEOOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC780", Offset = "0x7CAAD80", VA = "0x187CAC780")]
	private static void DCFNEMFMFCA(GDBFIEIFOFD DHCIGOGFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE7C0", Offset = "0x7CACDC0", VA = "0x187CAE7C0")]
	private static CancellationTokenRegistration NODOBLCAGHB(GDBFIEIFOFD DHCIGOGFOEM, CancellationToken ENHKOFNDDIH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC920", Offset = "0x7CAAF20", VA = "0x187CAC920")]
	private static void EFHJNNCGDFM(GDBFIEIFOFD DHCIGOGFOEM, Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CACAB0", Offset = "0x7CAB0B0", VA = "0x187CACAB0")]
	private void FFMIAAFGFOE(GDBFIEIFOFD DHCIGOGFOEM, Task LBMJEAPJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7CADB70", Offset = "0x7CAC170", VA = "0x187CADB70")]
	private static void IEGNOINNOMJ(Func<string> OIKCDENKJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF1F0", Offset = "0x7CAD7F0", VA = "0x187CAF1F0")]
	public MGKAAALGFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC870", Offset = "0x7CAAE70", VA = "0x187CAC870")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC7B00", Offset = "0x7CC6100", VA = "0x187CC7B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7FE0", Offset = "0x7CC65E0", VA = "0x187CC7FE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ACIDGJCDLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6D70", Offset = "0x7CB5370", VA = "0x187CB6D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB8390", Offset = "0x7CB6990", VA = "0x187CB8390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8730", Offset = "0x7CB6D30", VA = "0x187CB8730", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC08A0", Offset = "0x7CBEEA0", VA = "0x187CC08A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0B80", Offset = "0x7CBF180", VA = "0x187CC0B80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CD2D20", Offset = "0x7CD1320", VA = "0x187CD2D20", Slot = "5")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2B40", Offset = "0x7CD1140", VA = "0x187CD2B40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2CC0", Offset = "0x7CD12C0", VA = "0x187CD2CC0", Slot = "4")]
	public bool HAHOBNDICJG(CNLHFGLFLAC KCNPFBCDHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CD31C0", Offset = "0x7CD17C0", VA = "0x187CD31C0")]
	private void PGJGGBOBNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CD27D0", Offset = "0x7CD0DD0", VA = "0x187CD27D0")]
	private void AKPLLBFDIKN(BPPINHJEEIJ MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CD30D0", Offset = "0x7CD16D0", VA = "0x187CD30D0")]
	[AsyncStateMachine(typeof(KCHLCLEBEJB))]
	private Task OANPGPFPHEB(int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3000", Offset = "0x7CD1600", VA = "0x187CD3000")]
	private Func<CancellationToken, List<Task>> IJDMMDJFHAP(int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2300", Offset = "0x7CD0900", VA = "0x187CD2300")]
	private List<Task> AECFODHCLJI(int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2BA0", Offset = "0x7CD11A0", VA = "0x187CD2BA0")]
	[AsyncStateMachine(typeof(CJINNPMDFBH))]
	private Task FMAKMFABLFG(CNLHFGLFLAC KBKNECNKOFI, CancellationToken LAAJFAFNFCN, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2A70", Offset = "0x7CD1070", VA = "0x187CD2A70")]
	[AsyncStateMachine(typeof(GNFLKDPAHAJ))]
	private Task BFBAKLPHOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CD29F0", Offset = "0x7CD0FF0", VA = "0x187CD29F0")]
	private void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3290", Offset = "0x7CD1890", VA = "0x187CD3290")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LIKAAOCEMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC2A0", Offset = "0x7CCA8A0", VA = "0x187CCC2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IDCMNJJMJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3A30", Offset = "0x7CC2030", VA = "0x187CC3A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PCIKAOHIMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7CD22A0", Offset = "0x7CD08A0", VA = "0x187CD22A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DIFMBJNJHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7CBAA50", Offset = "0x7CB9050", VA = "0x187CBAA50")]
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
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "9")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8840", Offset = "0x7CC6E40", VA = "0x187CC8840", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8B80", Offset = "0x7CC7180", VA = "0x187CC8B80", Slot = "4")]
	public AHECFMBNCBG HBHDBABAKDP(Guid EHMIFANHMPO)
	{
		return default(AHECFMBNCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9220", Offset = "0x7CC7820", VA = "0x187CC9220", Slot = "5")]
	public bool OCDDHDAHAOD(Guid EHMIFANHMPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8850", Offset = "0x7CC6E50", VA = "0x187CC8850", Slot = "6")]
	public bool GAKIHJOFNMP(Guid EHMIFANHMPO, Task HALLDLPJOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8E10", Offset = "0x7CC7410", VA = "0x187CC8E10", Slot = "7")]
	public bool LLEBADGMFLH(Guid EHMIFANHMPO, GGLMIDJEDGD DNHNCONLMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8DA0", Offset = "0x7CC73A0", VA = "0x187CC8DA0", Slot = "8")]
	public Task<(GGLMIDJEDGD, Task)> IKNBHLBIMGO(Guid EHMIFANHMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8FF0", Offset = "0x7CC75F0", VA = "0x187CC8FF0")]
	private void MDLAMJHHIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9430", Offset = "0x7CC7A30", VA = "0x187CC9430")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC3D90", Offset = "0x7CC2390", VA = "0x187CC3D90")]
		public IKNANHBFMCE(GDBFIEIFOFD PNLPGKBGHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3C10", Offset = "0x7CC2210", VA = "0x187CC3C10")]
		public void APDCJKMBNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3D60", Offset = "0x7CC2360", VA = "0x187CC3D60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JBBBMMDCDLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC4F60", Offset = "0x7CC3560", VA = "0x187CC4F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCF7B0", Offset = "0x7CCDDB0", VA = "0x187CCF7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFC00", Offset = "0x7CCE200", VA = "0x187CCFC00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IFPMKGNEELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3A90", Offset = "0x7CC2090", VA = "0x187CC3A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FCLDFNGBJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE4C0", Offset = "0x7CBCAC0", VA = "0x187CBE4C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD02E0", Offset = "0x7CCE8E0", VA = "0x187CD02E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JEHDIEELCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6100", Offset = "0x7CC4700", VA = "0x187CC6100")]
		internal object MLDOFCGJCFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6080", Offset = "0x7CC4680", VA = "0x187CC6080")]
		internal void MBFIKAPIOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6040", Offset = "0x7CC4640", VA = "0x187CC6040")]
		internal object JIHBEMKBCHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7CC6000", Offset = "0x7CC4600", VA = "0x187CC6000")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCCAA0", Offset = "0x7CCB0A0", VA = "0x187CCCAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDA70", Offset = "0x7CCC070", VA = "0x187CCDA70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBA060", Offset = "0x7CB8660", VA = "0x187CBA060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool MMNJAMDMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAFC4F0", Offset = "0xAFAAF0", VA = "0x180AFC4F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA330", Offset = "0x7CB8930", VA = "0x187CBA330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9DC0", Offset = "0x7CB83C0", VA = "0x187CB9DC0", Slot = "4")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9860", Offset = "0x7CB7E60", VA = "0x187CB9860", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA240", Offset = "0x7CB8840", VA = "0x187CBA240")]
	[AsyncStateMachine(typeof(NFMPKALABLI))]
	private Task LGGAAFPFBOE(BBNKNABMABP JCKONIJGJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB96D0", Offset = "0x7CB7CD0", VA = "0x187CB96D0")]
	private void DGGKHFIPOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA0B0", Offset = "0x7CB86B0", VA = "0x187CBA0B0")]
	private void IALHOMNNMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA340", Offset = "0x7CB8940", VA = "0x187CBA340")]
	private void OEDBHEAMGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9D40", Offset = "0x7CB8340", VA = "0x187CB9D40")]
	private bool FOMKPALDCME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9C70", Offset = "0x7CB8270", VA = "0x187CB9C70")]
	[AsyncStateMachine(typeof(ONNLONNGAEM))]
	private void FFNCCKFPALI(int KHELFHBHLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7CB99D0", Offset = "0x7CB7FD0", VA = "0x187CB99D0")]
	private void FAMNGJLHAFJ([Out] IDisposable FCKMOJMEBAI, [Out] IDisposable MHHIMCDNMIE, [Out] IDisposable AOIODHAJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA4C0", Offset = "0x7CB8AC0", VA = "0x187CBA4C0")]
	private bool OHADLHNMOME(GDBFIEIFOFD PNLPGKBGHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9550", Offset = "0x7CB7B50", VA = "0x187CB9550")]
	private void CDOPDEMLCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7CB95A0", Offset = "0x7CB7BA0", VA = "0x187CB95A0")]
	[AsyncStateMachine(typeof(LOEPGBBEDEE))]
	private Task CPCJDAFJBFG(GDBFIEIFOFD PNLPGKBGHHP, KLIKFJJFGJN KEFMNOFFBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA980", Offset = "0x7CB8F80", VA = "0x187CBA980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBE1C0", Offset = "0x7CBC7C0", VA = "0x187CBE1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE450", Offset = "0x7CBCA50", VA = "0x187CBE450", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LKGDHCPAFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7CCCA40", Offset = "0x7CCB040", VA = "0x187CCCA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DNJAICJLCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB5F0", Offset = "0x7CB9BF0", VA = "0x187CBB5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IGMIDLPJBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3BB0", Offset = "0x7CC21B0", VA = "0x187CC3BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCDF80", Offset = "0x7CCC580", VA = "0x187CCDF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE850", Offset = "0x7CCCE50", VA = "0x187CCE850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HPNILNBJGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1CB0", Offset = "0x7CC02B0", VA = "0x187CC1CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBE580", Offset = "0x7CBCB80", VA = "0x187CBE580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF100", Offset = "0x7CBD700", VA = "0x187CBF100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCFCC0", Offset = "0x7CCE2C0", VA = "0x187CCFCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7CD01F0", Offset = "0x7CCE7F0", VA = "0x187CD01F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PKDEFGEEHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3320", Offset = "0x7CD1920", VA = "0x187CD3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCE8B0", Offset = "0x7CCCEB0", VA = "0x187CCE8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEEE0", Offset = "0x7CCD4E0", VA = "0x187CCEEE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DFFCEGLCODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA9F0", Offset = "0x7CB8FF0", VA = "0x187CBA9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NHFEIHIGBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFC60", Offset = "0x7CCE260", VA = "0x187CCFC60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CBD3A0", Offset = "0x7CBB9A0", VA = "0x187CBD3A0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDE30", Offset = "0x7CBC430", VA = "0x187CBDE30", Slot = "6")]
	[AsyncStateMachine(typeof(FBDKCDFKHGD))]
	public Task<IICNNDCPJEP> MIGBBFJGPHO(CancellationToken OBDPPPBJBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDAA0", Offset = "0x7CBC0A0", VA = "0x187CBDAA0", Slot = "4")]
	public void MFHFHJDKEDK(KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD520", Offset = "0x7CBBB20", VA = "0x187CBD520", Slot = "5")]
	public void JNHAKONBPOC(KKBOOBAMIML CICOFGCAFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD880", Offset = "0x7CBBE80", VA = "0x187CBD880")]
	[AsyncStateMachine(typeof(MAADJOBFMAK))]
	private Task LAIMLHKNANN(KKBOOBAMIML NEMAHPGAGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD990", Offset = "0x7CBBF90", VA = "0x187CBD990")]
	[AsyncStateMachine(typeof(FEPMMGDFBNP))]
	private Task LFGJKNFONMK(KKBOOBAMIML KHKPBKPELIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCDA0", Offset = "0x7CBB3A0", VA = "0x187CBCDA0")]
	[AsyncStateMachine(typeof(NHIGAFHOHNO))]
	private Task<GPIPDBGGDOE> ACCLIEGHJCB(KKBOOBAMIML NEMAHPGAGLG, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD490", Offset = "0x7CBBA90", VA = "0x187CBD490")]
	private OKCNIPGMDHK IGMMEANMPKO(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCEF0", Offset = "0x7CBB4F0", VA = "0x187CBCEF0")]
	[AsyncStateMachine(typeof(MANPDNLCBNC))]
	private Task ALADGHNMBNE(GPIPDBGGDOE FFEBDLHFDKK, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDF40", Offset = "0x7CBC540", VA = "0x187CBDF40")]
	private GPIPDBGGDOE OAGEDGCLKBH(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x32764C0", Offset = "0x3274AC0", VA = "0x1832764C0")]
	private T ECDIJKIJKOB<T>(T KBGCCIOIGBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD010", Offset = "0x7CBB610", VA = "0x187CBD010")]
	private GPIPDBGGDOE DAIBADBJHBE(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FAEODOHFKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE150", Offset = "0x7CBC750", VA = "0x187CBE150")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CEDOALMAMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7C10", Offset = "0x7CB6210", VA = "0x187CB7C10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CB5FB0", Offset = "0x7CB45B0", VA = "0x187CB5FB0", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5320", Offset = "0x7CB3920", VA = "0x187CB5320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5B80", Offset = "0x7CB4180", VA = "0x187CB5B80", Slot = "4")]
	public AHECFMBNCBG HGLBMLMGBFM(KKBOOBAMIML LFICHDNKEMG)
	{
		return default(AHECFMBNCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4E80", Offset = "0x7CB3480", VA = "0x187CB4E80", Slot = "5")]
	public void BFIIGPGIAMF(Guid EHMIFANHMPO, Task HALLDLPJOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5870", Offset = "0x7CB3E70", VA = "0x187CB5870")]
	private void EHIEJBKJENP(byte BEHNKEPLHBF, int GNEBHLDFAOJ, object KEMDCIKNPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6120", Offset = "0x7CB4720", VA = "0x187CB6120")]
	private void IFBGPCAAPMH(DOJBJHGDOGF NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB53D0", Offset = "0x7CB39D0", VA = "0x187CB53D0")]
	private void EANNENCBMHE(DOJBJHGDOGF NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5940", Offset = "0x7CB3F40", VA = "0x187CB5940")]
	private void GICKBBEILJH(DOJBJHGDOGF NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6AC0", Offset = "0x7CB50C0", VA = "0x187CB6AC0")]
	private GGLMIDJEDGD MIPCONGCEEF(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7CB68B0", Offset = "0x7CB4EB0", VA = "0x187CB68B0")]
	private void LKIFKAINBJP(KKBOOBAMIML KHKPBKPELIC, GGLMIDJEDGD DNHNCONLMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7CB66C0", Offset = "0x7CB4CC0", VA = "0x187CB66C0")]
	private bool LFPPEBLPELN(KKBOOBAMIML KHKPBKPELIC, GGLMIDJEDGD DNHNCONLMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5650", Offset = "0x7CB3C50", VA = "0x187CB5650")]
	private bool EFIALGIBCKB(KKBOOBAMIML CNBLPINPMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5090", Offset = "0x7CB3690", VA = "0x187CB5090")]
	private bool CHFFNHLHHNB(byte BEHNKEPLHBF, ExitGames.Client.Photon.Hashtable NBGBHBICCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KAJLLNGOKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7A90", Offset = "0x7CC6090", VA = "0x187CC7A90")]
		internal object HMELCPHOAHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC78E0", Offset = "0x7CC5EE0", VA = "0x187CC78E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB7C80", Offset = "0x7CB6280", VA = "0x187CB7C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8320", Offset = "0x7CB6920", VA = "0x187CB8320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EIECNHJFFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCC90", Offset = "0x7CBB290", VA = "0x187CBCC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LBBPEAEDBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA8D0", Offset = "0x7CC8ED0", VA = "0x187CCA8D0")]
		internal object NJDOMBDJOOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA7F0", Offset = "0x7CC8DF0", VA = "0x187CCA7F0")]
		internal object DLCPKJGOBFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA860", Offset = "0x7CC8E60", VA = "0x187CCA860")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC1370", Offset = "0x7CBF970", VA = "0x187CC1370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1C40", Offset = "0x7CC0240", VA = "0x187CC1C40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CBB0F0", Offset = "0x7CB96F0", VA = "0x187CBB0F0", Slot = "5")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB1A0", Offset = "0x7CB97A0", VA = "0x187CBB1A0", Slot = "4")]
	[AsyncStateMachine(typeof(CJECPMIKBBJ))]
	private Task<GGLMIDJEDGD> IEKPCGHFLMG(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB2C0", Offset = "0x7CB98C0", VA = "0x187CBB2C0")]
	private bool IIHFICEBLHH(IICNNDCPJEP MNGFNEKIDGN, [Out] GGLMIDJEDGD BIEIOPPGBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB4B0", Offset = "0x7CB9AB0", VA = "0x187CBB4B0")]
	[AsyncStateMachine(typeof(HLCPPLIFIMJ))]
	private Task<GGLMIDJEDGD> OPELMCPCPAM(KKBOOBAMIML NEMAHPGAGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBAAB0", Offset = "0x7CB90B0", VA = "0x187CBAAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB080", Offset = "0x7CB9680", VA = "0x187CBB080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IFPODFOCEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7CC3B00", Offset = "0x7CC2100", VA = "0x187CC3B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCA190", Offset = "0x7CC8790", VA = "0x187CCA190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA780", Offset = "0x7CC8D80", VA = "0x187CCA780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCA940", Offset = "0x7CC8F40", VA = "0x187CCA940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCADA0", Offset = "0x7CC93A0", VA = "0x187CCADA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JEPFNFEEJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xCFA4F0", Offset = "0xCF8AF0", VA = "0x180CFA4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCAE10", Offset = "0x7CC9410", VA = "0x187CCAE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7CCB4B0", Offset = "0x7CC9AB0", VA = "0x187CCB4B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GHKGGFBDLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC07F0", Offset = "0x7CBEDF0", VA = "0x187CC07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC80A0", Offset = "0x7CC66A0", VA = "0x187CC80A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7CC87D0", Offset = "0x7CC6DD0", VA = "0x187CC87D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CC49B0", Offset = "0x7CC2FB0", VA = "0x187CC49B0", Slot = "5")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4850", Offset = "0x7CC2E50", VA = "0x187CC4850", Slot = "4")]
	[AsyncStateMachine(typeof(DIOPNOMJDOE))]
	public Task<HLOJEJEEEIJ> DNCEKBDAJFI(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, GDBFIEIFOFD DHCIGOGFOEM, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC46F0", Offset = "0x7CC2CF0", VA = "0x187CC46F0")]
	[AsyncStateMachine(typeof(KOPMGFCPBFH))]
	private Task<EPDFKONBMMJ> CMJDMNBOIGG(GDBFIEIFOFD DHCIGOGFOEM, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4A40", Offset = "0x7CC3040", VA = "0x187CC4A40")]
	[AsyncStateMachine(typeof(LGHAEGBIJLK))]
	private Task<HLOJEJEEEIJ> JGPKANGEGEJ(GDBFIEIFOFD DHCIGOGFOEM, EPDFKONBMMJ OMEABIGPMID, long OGHBKCHPPKA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4BB0", Offset = "0x7CC31B0", VA = "0x187CC4BB0")]
	[AsyncStateMachine(typeof(LGOOFGMOGAE))]
	private Task<(DDDGOPGHMJC, long)> KCNJLCCLMDI(GDBFIEIFOFD DHCIGOGFOEM, EPDFKONBMMJ OMEABIGPMID, long OGHBKCHPPKA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4D20", Offset = "0x7CC3320", VA = "0x187CC4D20")]
	[AsyncStateMachine(typeof(KHHNAMOGFHM))]
	private Task<(DDDGOPGHMJC, long)> PIKOOMKPLHB(GDBFIEIFOFD GPFIGFDOMGJ, KOLBKODMCOP DFNCGPOAIGO, long OGHBKCHPPKA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EBOIBDKENKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB650", Offset = "0x7CB9C50", VA = "0x187CBB650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC0170", Offset = "0x7CBE770", VA = "0x187CC0170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0780", Offset = "0x7CBED80", VA = "0x187CC0780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCEF40", Offset = "0x7CCD540", VA = "0x187CCEF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF540", Offset = "0x7CCDB40", VA = "0x187CCF540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KHAJEJLKBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8040", Offset = "0x7CC6640", VA = "0x187CC8040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC94F0", Offset = "0x7CC7AF0", VA = "0x187CC94F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA0E0", Offset = "0x7CC86E0", VA = "0x187CCA0E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCC6F0", Offset = "0x7CCACF0", VA = "0x187CCC6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC500", Offset = "0x7CCAB00", VA = "0x187CCC500", Slot = "8")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC7B0", Offset = "0x7CCADB0", VA = "0x187CCC7B0", Slot = "4")]
	[AsyncStateMachine(typeof(FJNGOKCLLNP))]
	public Task<KKBOOBAMIML> LLJLNJMCBHI(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC300", Offset = "0x7CCA900", VA = "0x187CCC300", Slot = "5")]
	[AsyncStateMachine(typeof(MMJOGDMDBPC))]
	public Task<KKBOOBAMIML> EKKLCMPHPCM(CancellationToken LAEIHJHNGEK, OKCNIPGMDHK LNEKCGEMFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC450", Offset = "0x7CCAA50", VA = "0x187CCC450", Slot = "6")]
	public LGACCJIPMFL EPCMPIFOELB(GPIPDBGGDOE BINLGGPBHKF, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC910", Offset = "0x7CCAF10", VA = "0x187CCC910", Slot = "7")]
	public LGACCJIPMFL PCFPIJDPFLE(GPIPDBGGDOE BINLGGPBHKF, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC590", Offset = "0x7CCAB90", VA = "0x187CCC590")]
	[AsyncStateMachine(typeof(KNKJBDHHHFP))]
	private Task<KKBOOBAMIML> JMNHNLJPNKA(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x34C8870", Offset = "0x34C6E70", VA = "0x1834C8870")]
	private static byte[] NNIEKIEGNAE(KKBOOBAMIML MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBBC20", Offset = "0x7CBA220", VA = "0x187CBBC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private static GGLMIDJEDGD FLHKLEFIOME
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB820", Offset = "0x7CB9E20", VA = "0x187CBB820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBAB0", Offset = "0x7CBA0B0", VA = "0x187CBBAB0", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB6B0", Offset = "0x7CB9CB0", VA = "0x187CBB6B0", Slot = "4")]
	public GGLMIDJEDGD DCODFNMJCMH(OPHKANJGPPK PCCBNDDCHNF, IICNNDCPJEP IJECCKDIIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB830", Offset = "0x7CB9E30", VA = "0x187CBB830", Slot = "5")]
	public GGLMIDJEDGD GJFDLFDAOAI(OPHKANJGPPK OFAFOALBCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBC70", Offset = "0x7CBA270", VA = "0x187CBBC70")]
	private static GGLMIDJEDGD KCIIPNEEJDL(AOEFHBHKKHL CEGFAIJENKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public EFCMDHEGPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class KOGNBEPLDDK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA150", Offset = "0x7CC8750", VA = "0x187CCA150")]
	public KOGNBEPLDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F88270", Offset = "0x6F86870", VA = "0x186F88270")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CB8990", Offset = "0x7CB6F90", VA = "0x187CB8990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CB94E0", Offset = "0x7CB7AE0", VA = "0x187CB94E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CBBC80", Offset = "0x7CBA280", VA = "0x187CBBC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC3E0", Offset = "0x7CBA9E0", VA = "0x187CBC3E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC7370", Offset = "0x7CC5970", VA = "0x187CC7370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7880", Offset = "0x7CC5E80", VA = "0x187CC7880", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCB520", Offset = "0x7CC9B20", VA = "0x187CCB520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CCBC70", Offset = "0x7CCA270", VA = "0x187CCBC70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCF5B0", Offset = "0x7CCDBB0", VA = "0x187CCF5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF750", Offset = "0x7CCDD50", VA = "0x187CCF750", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC0BE0", Offset = "0x7CBF1E0", VA = "0x187CC0BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1310", Offset = "0x7CBF910", VA = "0x187CC1310", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC1D10", Offset = "0x7CC0310", VA = "0x187CC1D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2180", Offset = "0x7CC0780", VA = "0x187CC2180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CC6DA0", Offset = "0x7CC53A0", VA = "0x187CC6DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CC7310", Offset = "0x7CC5910", VA = "0x187CC7310", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CC5360", Offset = "0x7CC3960", VA = "0x187CC5360", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x10CBD00", Offset = "0x10CA300", VA = "0x1810CBD00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5740", Offset = "0x7CC3D40", VA = "0x187CC5740")]
	private void LBCLMLGFPAA(float AGIFAONKJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5610", Offset = "0x7CC3C10", VA = "0x187CC5610", Slot = "4")]
	[AsyncStateMachine(typeof(CPDHFEDBPPN))]
	public Task<GGLMIDJEDGD> KHCOBLOPMED(JICNBBCNCAC CIIBJONMFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5AA0", Offset = "0x7CC40A0", VA = "0x187CC5AA0", Slot = "5")]
	[AsyncStateMachine(typeof(EGCFNJKEEJF))]
	public Task NBOEIFCOODG([Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x10CBD00", Offset = "0x10CA300", VA = "0x1810CBD00")]
	public void MBBDCEMMKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CC51F0", Offset = "0x7CC37F0", VA = "0x187CC51F0")]
	private BIPDBNACGLK HINKEEHELHK(JICNBBCNCAC CIIBJONMFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4FF0", Offset = "0x7CC35F0", VA = "0x187CC4FF0")]
	[AsyncStateMachine(typeof(JMHBNFLCECD))]
	private Task BCFHKBHIMBO(CancellationToken DGLOFFGGICM, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5510", Offset = "0x7CC3B10", VA = "0x187CC5510")]
	[AsyncStateMachine(typeof(LIHGKLIDDAC))]
	private Task IOJBKKHPANI(CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5B90", Offset = "0x7CC4190", VA = "0x187CC5B90")]
	[AsyncStateMachine(typeof(NDNFLKDAGCL))]
	private Task NDIEMEJIKBJ([Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5E10", Offset = "0x7CC4410", VA = "0x187CC5E10")]
	[AsyncStateMachine(typeof(HJPEOALELDD))]
	private Task OBHDNGCMGBN(CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5F00", Offset = "0x7CC4500", VA = "0x187CC5F00")]
	[AsyncStateMachine(typeof(HPOFMLGEACL))]
	private Task OCGMNMOLEJA(CancellationToken EKNLLBIEBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5C80", Offset = "0x7CC4280", VA = "0x187CC5C80")]
	private Task OBBBKFFHHBO(DPOOOLNKMNK KEGDNPBCBNK, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7CC50E0", Offset = "0x7CC36E0", VA = "0x187CC50E0")]
	[AsyncStateMachine(typeof(JHNJBGHPDFK))]
	private Task ENPDKIEALDB(DPOOOLNKMNK KEGDNPBCBNK, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5820", Offset = "0x7CC3E20", VA = "0x187CC5820")]
	private bool LDPDMFOPNIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCBCD0", Offset = "0x7CCA2D0", VA = "0x187CCBCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC240", Offset = "0x7CCA840", VA = "0x187CCC240", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CCDD10", Offset = "0x7CCC310", VA = "0x187CCDD10", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDBC0", Offset = "0x7CCC1C0", VA = "0x187CCDBC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDC10", Offset = "0x7CCC210", VA = "0x187CCDC10", Slot = "5")]
	[AsyncStateMachine(typeof(LIHIGICKKOJ))]
	public Task FGPHEEIMFAD(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDF20", Offset = "0x7CCC520", VA = "0x187CCDF20", Slot = "4")]
	public GGLMIDJEDGD LDPDMFOPNIP(OPHKANJGPPK PCCBNDDCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDAD0", Offset = "0x7CCC0D0", VA = "0x187CCDAD0")]
	private ANEDJOBPDGC CFIJCCNCHLF(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public LPCOJDDNFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class ILBCMDBLFKK
{
	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4270", Offset = "0x7CC2870", VA = "0x187CC4270")]
	public static void LNPDIMNANJI(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4590", Offset = "0x7CC2B90", VA = "0x187CC4590")]
	internal static void NPJBGAOHAMG(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7CC44B0", Offset = "0x7CC2AB0", VA = "0x187CC44B0")]
	internal static void NLHLFPAENPL(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3E40", Offset = "0x7CC2440", VA = "0x187CC3E40")]
	internal static void JBKHBMIPEGM(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3413910", Offset = "0x3411F10", VA = "0x183413910")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HAJLHKBEJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDAA0", Offset = "0x7CDC0A0", VA = "0x187CDDAA0")]
		internal object HHJBKAHCBLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly MCMAIIKCICA IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6A40", Offset = "0x7CE5040", VA = "0x187CE6A40")]
	public ExitGames.Client.Photon.Hashtable IMJDHHAECMF(KKBOOBAMIML MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6AD0", Offset = "0x7CE50D0", VA = "0x187CE6AD0", Slot = "5")]
	protected override void KICCMLHNNCD(KKBOOBAMIML MIALAMIFNLM, IDictionary<object, object> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6700", Offset = "0x7CE4D00", VA = "0x187CE6700", Slot = "6")]
	public override KKBOOBAMIML GFOCOOKFNLL(IDictionary<object, object> GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6930", Offset = "0x7CE4F30", VA = "0x187CE6930")]
	private static void IEGNOINNOMJ(string PDMAGOJMJEB, KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6F50", Offset = "0x7CE5550", VA = "0x187CE6F50")]
	public MCMAIIKCICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6C00", Offset = "0x7CE5200", VA = "0x187CE6C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE9160", Offset = "0x7CE7760", VA = "0x187CE9160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9140", Offset = "0x7CE7740", VA = "0x187CE9140")]
	public static bool GBIDAPBNAJP(this GGLMIDJEDGD DNHNCONLMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CE93C0", Offset = "0x7CE79C0", VA = "0x187CE93C0")]
	public static GGLMIDJEDGD KCIIPNEEJDL(AOEFHBHKKHL DCLADEMODOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7CE91C0", Offset = "0x7CE77C0", VA = "0x187CE91C0")]
	public static GGLMIDJEDGD IAEEJIKKGPP(IEnumerable<GGLMIDJEDGD> KNEHOIAJNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8EE0", Offset = "0x7CE74E0", VA = "0x187CE8EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PDKLLDCFNGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1360FC0", Offset = "0x135F5C0", VA = "0x181360FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CD7960", Offset = "0x7CD5F60", VA = "0x187CD7960", Slot = "4")]
	public void CGJCKCBCGDD(OKGDMFMHACK MPMNOKLGMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7A10", Offset = "0x7CD6010", VA = "0x187CD7A10", Slot = "5")]
	public void KPHLKODFGBA(OKGDMFMHACK MPMNOKLGMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7CD79C0", Offset = "0x7CD5FC0", VA = "0x187CD79C0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7A70", Offset = "0x7CD6070", VA = "0x187CD7A70")]
	protected GGLMIDJEDGD OPJNPGGHPHE(OPHKANJGPPK OFAFOALBCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD7D10", Offset = "0x7CD6310", VA = "0x187CD7D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PPNPJEOFEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE750", Offset = "0x7CECD50", VA = "0x187CEE750")]
		internal object HAEGLPBHOAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE7C0", Offset = "0x7CDCDC0", VA = "0x187CDE7C0")]
	[UnityEngine.Scripting.Preserve]
	public JNMPLEKFFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0D90", Offset = "0x7CDF390", VA = "0x187CE0D90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CHPOCCDLEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD7880", Offset = "0x7CD5E80", VA = "0x187CD7880")]
		internal object HHFLFFJJBCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE7C0", Offset = "0x7CDCDC0", VA = "0x187CDE7C0")]
	[UnityEngine.Scripting.Preserve]
	public HEFELHIFDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE6B0", Offset = "0x7CDCCB0", VA = "0x187CDE6B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CJKKOHHKDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD78E0", Offset = "0x7CD5EE0", VA = "0x187CD78E0")]
		internal object HEEAPOPNCPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2680", Offset = "0x7CE0C80", VA = "0x187CE2680")]
	public static FGFDKLMANEA<string> GBMBGLFNOGP(IBCMILIKEJG DDKJAEALMGF, [Optional] string KDCJEBLDBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE25C0", Offset = "0x7CE0BC0", VA = "0x187CE25C0")]
	public static void CICAEOIMCJN(FGFDKLMANEA<string> ACNLNBKGHCE, IBCMILIKEJG DDKJAEALMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2760", Offset = "0x7CE0D60", VA = "0x187CE2760")]
	public static string IHMCFIOKBKL(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal static class ANBAMBBKAHF
{
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4030", Offset = "0x7CD2630", VA = "0x187CD4030")]
	public static void KBJHCPGNBBI(this JFIOHCKEEIP MGMCFGLJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4020", Offset = "0x7CD2620", VA = "0x187CD4020")]
	public static void DGMGEEEGKNK(this JFIOHCKEEIP MGMCFGLJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3F00", Offset = "0x7CD2500", VA = "0x187CD3F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD8530", Offset = "0x7CD6B30", VA = "0x187CD8530", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public int AKNODCDPMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD88F0", Offset = "0x7CD6EF0", VA = "0x187CD88F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int NKBFAKMAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7CD84E0", Offset = "0x7CD6AE0", VA = "0x187CD84E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int KMDCADAAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event BMBNGCGJOIM.OFOPFDAOBOK BAGHFLOBLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FJMKBAPIJAM LHFOAEPBCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8850", Offset = "0x7CD6E50", VA = "0x187CD8850", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8580", Offset = "0x7CD6B80", VA = "0x187CD8580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> PGBACEBCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<OPHKANJGPPK> KPAOCMPFANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action HPIDINHPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8440", Offset = "0x7CD6A40", VA = "0x187CD8440", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8620", Offset = "0x7CD6C20", VA = "0x187CD8620", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0xBBF2E0", Offset = "0xBBD8E0", VA = "0x180BBF2E0")]
	public DDNGFGBIIKD(LIIDEAJGIMB BKMEGKKMPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7CD87A0", Offset = "0x7CD6DA0", VA = "0x187CD87A0", Slot = "8")]
	public bool LABMAAMFCPG(byte BEHNKEPLHBF, object FNCHNJICPAH, APIINIHDAID HBPNGGLDACB, SendOptions DAEFANOOJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7CD86C0", Offset = "0x7CD6CC0", VA = "0x187CD86C0", Slot = "16")]
	public OPHKANJGPPK IAOPBEKPMAP(int NJNOPMJJKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "19")]
	public void BJPHDIPLHBD(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "20")]
	public void INFNFEODANG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "21")]
	public void DHFIKMLHMPE(object LAAJFAFNFCN, bool LGLLAKCPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8940", Offset = "0x7CD6F40", VA = "0x187CD8940", Slot = "22")]
	public IDisposable PIHIMIFAALK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "23")]
	private bool LMAIFDBLKBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "24")]
	public void BDLIHPFLNBL(StringBuilder IICLAANMIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xDE0820", Offset = "0xDDEE20", VA = "0x180DE0820", Slot = "25")]
	public bool HEJANPGJFCG(bool NJNGBOFHOIL, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xD551C0", Offset = "0xD537C0", VA = "0x180D551C0", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	public DOJBJHGDOGF(IDictionary<object, object> NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8E50", Offset = "0x7CD7450", VA = "0x187CD8E50")]
	public bool JLMBHIIEEIK([Out] KKBOOBAMIML MIALAMIFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8C60", Offset = "0x7CD7260", VA = "0x187CD8C60")]
	public Guid CINEDAJDELO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8D10", Offset = "0x7CD7310", VA = "0x187CD8D10")]
	public GGLMIDJEDGD FADLGBJPEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8F00", Offset = "0x7CD7500", VA = "0x187CD8F00")]
	public static ExitGames.Client.Photon.Hashtable OILMBKHFGKP(KKBOOBAMIML MIALAMIFNLM, GGLMIDJEDGD DNHNCONLMMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal static class BKOHJMBFGEE
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6670", Offset = "0x7CD4C70", VA = "0x187CD6670")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE06B0", Offset = "0x7CDECB0", VA = "0x187CE06B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0890", Offset = "0x7CDEE90", VA = "0x187CE0890", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE71E0", Offset = "0x7CE57E0", VA = "0x187CE71E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7370", Offset = "0x7CE5970", VA = "0x187CE7370")]
	public MHOKGHJKDDN(CancellationToken LAEIHJHNGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7260", Offset = "0x7CE5860", VA = "0x187CE7260")]
	[AsyncStateMachine(typeof(JHDDMGEPHFC))]
	public Task EFNPPBJIOOC(Func<CancellationToken, List<Task>> CMKCNDOGGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7210", Offset = "0x7CE5810", VA = "0x187CE7210", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E0AA90", Offset = "0x4E09090", VA = "0x184E0AA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x477D850", Offset = "0x477BE50", VA = "0x18477D850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly GFADJGFDDHP<TGetDataArg, TData> JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	internal LPKPFNJIIOO(GFADJGFDDHP<TGetDataArg, TData> GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x4BD6A80", Offset = "0x4BD5080", VA = "0x184BD6A80")]
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
	[Cpp2IlInjected.Address(RVA = "0x3198EE0", Offset = "0x31974E0", VA = "0x183198EE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B9E1B0", Offset = "0x4B9C7B0", VA = "0x184B9E1B0")]
	public KKHLHELFLNI(int FOBKIBNHAIN, [Optional] int? DKJHDEECFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE12C0", Offset = "0x7CDF8C0", VA = "0x187CE12C0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DDCHFNDHFBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public CPKBGFOMDMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x4FEDE60", Offset = "0x4FEC460", VA = "0x184FEDE60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public OEIFHGLENKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x4FEDE60", Offset = "0x4FEC460", VA = "0x184FEDE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4632850", Offset = "0x4630E50", VA = "0x184632850")]
		internal HFBFNOIKNHI(BHPLBCGMGON OAHKGNHNFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x46326C0", Offset = "0x4630CC0", VA = "0x1846326C0", Slot = "4")]
		public void HACHOHENIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x4632730", Offset = "0x4630D30", VA = "0x184632730", Slot = "5")]
		public NKGPFFCLEIB<T> MMJADBGGLEE(string BHPFPDNBMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x46325A0", Offset = "0x4630BA0", VA = "0x1846325A0", Slot = "6")]
		public NKGPFFCLEIB<T> EJGHJFBIGLA(JEJADIEGMNL<T> DPGENFDLIOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x46326F0", Offset = "0x4630CF0", VA = "0x1846326F0", Slot = "7")]
		public NKGPFFCLEIB<T> IPLLFLFPJCJ(int HKJCJLGBMOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x4632470", Offset = "0x4630A70", VA = "0x184632470", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DEE720", Offset = "0x4DECD20", VA = "0x184DEE720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x4DEEBC0", Offset = "0x4DED1C0", VA = "0x184DEEBC0")]
		public MIPLIGONKNP(Dictionary<Type, int> GIPOGJJNGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x4DEEA10", Offset = "0x4DED010", VA = "0x184DEEA10")]
		public void HBHDBABAKDP(Type LKMGECEEGEE, TVal DGOEGFOLJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4DEE880", Offset = "0x4DECE80", VA = "0x184DEE880")]
		public bool GBPPMFIDIFK(Type NIECELIGEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x4DEEB70", Offset = "0x4DED170", VA = "0x184DEEB70")]
		public bool NKNKPAELMGK(TVal KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x4777F70", Offset = "0x4776570", VA = "0x184777F70")]
		public TVal NPPDIJEBOHO(Type BMIPLDLMPCD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x4DEE8D0", Offset = "0x4DECED0", VA = "0x184DEE8D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x40D9830", Offset = "0x40D7E30", VA = "0x1840D9830", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CD6280", Offset = "0x7CD4880", VA = "0x187CD6280", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public BIKJNIAMLLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x7CD62D0", Offset = "0x7CD48D0", VA = "0x187CD62D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x7CD5CC0", Offset = "0x7CD42C0", VA = "0x187CD5CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7CD5C20", Offset = "0x7CD4220", VA = "0x187CD5C20")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7CD5C70", Offset = "0x7CD4270", VA = "0x187CD5C70")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7CD6230", Offset = "0x7CD4830", VA = "0x187CD6230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD6170", Offset = "0x7CD4770", VA = "0x187CD6170", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KKHLHELFLNI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD6170", Offset = "0x7CD4770", VA = "0x187CD6170", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CD4480", Offset = "0x7CD2A80", VA = "0x187CD4480")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5870", Offset = "0x7CD3E70", VA = "0x187CD5870")]
	[RecRoom.NoEngine.Common.Preserve]
	public BHPLBCGMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380", Slot = "4")]
	public NKGPFFCLEIB<T> KDDEFCMPNOC<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4D80", Offset = "0x7CD3380", VA = "0x187CD4D80", Slot = "5")]
	public MBBDEMCCEJA KAMDDKHMIJC(Exception DADIPHEHDBH)
	{
		return default(MBBDEMCCEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7CD48B0", Offset = "0x7CD2EB0", VA = "0x187CD48B0", Slot = "6")]
	public KKHLHELFLNI FAMIBNGENCK(Exception? DADIPHEHDBH)
	{
		return default(KKHLHELFLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7CD43E0", Offset = "0x7CD29E0", VA = "0x187CD43E0", Slot = "7")]
	[IteratorStateMachine(typeof(BIKJNIAMLLN))]
	public IEnumerable<KKHLHELFLNI> AAHOAEOEGBI(Exception DADIPHEHDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5120", Offset = "0x7CD3720", VA = "0x187CD5120", Slot = "8")]
	public string LKFDCEEKHOJ(Exception? DADIPHEHDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4E10", Offset = "0x7CD3410", VA = "0x187CD4E10")]
	private string LIEDIEAHMLE(AggregateException JFCJJJCCDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5270", Offset = "0x7CD3870", VA = "0x187CD5270")]
	private void NMCBEGMPFOM(Type NIECELIGEPL, int HKJCJLGBMOM, CABJMDHPFFL? DACGCJPJGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4660", Offset = "0x7CD2C60", VA = "0x187CD4660")]
	private void COHAJHIHDEE(Type NIECELIGEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4AB0", Offset = "0x7CD30B0", VA = "0x187CD4AB0")]
	private void FAPPOPDCEKO(Type NIECELIGEPL, LFOICBAFJGI HMEAFCHDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5620", Offset = "0x7CD3C20", VA = "0x187CD5620")]
	private static int PFKNNOFOKOL(Type NIECELIGEPL, Dictionary<Type, int> GIPOGJJNGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x3198F70", Offset = "0x3197570", VA = "0x183198F70")]
	private static bool DFHBDEGHABM<TVal>(MIPLIGONKNP<TVal> BMKDAHEBDHE, Type NIECELIGEPL, [Out] TVal KBGCCIOIGBD) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4580", Offset = "0x7CD2B80", VA = "0x187CD4580")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CE5870", Offset = "0x7CE3E70", VA = "0x187CE5870")]
	public MBBDEMCCEJA(string KMIFKCIEOPL, KKHLHELFLNI HKJCJLGBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x7CE57D0", Offset = "0x7CE3DD0", VA = "0x187CE57D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public long IMIDPFKKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6280", Offset = "0x7CE4880", VA = "0x187CE6280")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public long LOAIIAPAPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5980", Offset = "0x7CE3F80", VA = "0x187CE5980")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public long HPIIPLKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5CB0", Offset = "0x7CE42B0", VA = "0x187CE5CB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public string MPHGGLNFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6240", Offset = "0x7CE4840", VA = "0x187CE6240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public JBLLOOMMFJC LJFLEIDNBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xC0C580", Offset = "0xC0AB80", VA = "0x180C0C580")]
		get
		{
			return default(JBLLOOMMFJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7CE5890", Offset = "0x7CE3E90", VA = "0x187CE5890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public long NAJNFJJHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6660", Offset = "0x7CE4C60", VA = "0x187CE6660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE66C0", Offset = "0x7CE4CC0", VA = "0x187CE66C0")]
	[UnityEngine.Scripting.Preserve]
	public MBLNBFNLDAN([IBJCGEMJMJL(null)] CDIHIOEBGKL LOHJEJBMJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE59E0", Offset = "0x7CE3FE0", VA = "0x187CE59E0")]
	private void HGCHPFIOJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5D10", Offset = "0x7CE4310", VA = "0x187CE5D10")]
	public void KKIJNNAMHCF(long FFFLOIOFAMB, long OGHBKCHPPKA, [Optional] long? KGGKGOKAJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE61A0", Offset = "0x7CE47A0", VA = "0x187CE61A0")]
	public void LGLBKGIPAGN(long KGGKGOKAJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5C30", Offset = "0x7CE4230", VA = "0x187CE5C30")]
	public void IGLOAGBAAAJ(string AEDDPJHJGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE62E0", Offset = "0x7CE48E0", VA = "0x187CE62E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDC370", Offset = "0x7CDA970", VA = "0x187CDC370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7CDC8B0", Offset = "0x7CDAEB0", VA = "0x187CDC8B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GBPEBAFJEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB700", Offset = "0x7CD9D00", VA = "0x187CDB700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE8860", Offset = "0x7CE6E60", VA = "0x187CE8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8E70", Offset = "0x7CE7470", VA = "0x187CE8E70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x45ECB10", Offset = "0x45EB110", VA = "0x1845ECB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D32470", Offset = "0x3D30A70", VA = "0x183D32470", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE0EA0", Offset = "0x7CDF4A0", VA = "0x187CE0EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1060", Offset = "0x7CDF660", VA = "0x187CE1060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IJMHICPNOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CDF870", Offset = "0x7CDDE70", VA = "0x187CDF870")]
		internal object HABMPLLPDBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CDF8D0", Offset = "0x7CDDED0", VA = "0x187CDF8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OAPBDDPIPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9420", Offset = "0x7CE7A20", VA = "0x187CE9420")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AHKFMHKNONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3E90", Offset = "0x7CD2490", VA = "0x187CD3E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ADBBIMFAMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3E20", Offset = "0x7CD2420", VA = "0x187CD3E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MFLCEOGPIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6F90", Offset = "0x7CE5590", VA = "0x187CE6F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CE4F90", Offset = "0x7CE3590", VA = "0x187CE4F90")]
	public LGACCJIPMFL(GPIPDBGGDOE FFEBDLHFDKK, FJGBFJOGCIJ HMFKALHBDAA, KOCGNCDMOPN MGMCFGLJIGI, EDKLJOILFEA KMMOJIJCKBA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE40C0", Offset = "0x7CE26C0", VA = "0x187CE40C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4310", Offset = "0x7CE2910", VA = "0x187CE4310")]
	public void HKHGNPDOKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CE40D0", Offset = "0x7CE26D0", VA = "0x187CE40D0")]
	public void EOLPKLNFHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4000", Offset = "0x7CE2600", VA = "0x187CE4000")]
	public void CGNFCNLOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4540", Offset = "0x7CE2B40", VA = "0x187CE4540")]
	[AsyncStateMachine(typeof(GFLOEPCPDID))]
	internal Task<KKBOOBAMIML> JDNEDLMJOAG(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, KKBOOBAMIML FNHJGBHLJLO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x34C8870", Offset = "0x34C6E70", VA = "0x1834C8870")]
	private static byte[] NIEEBDLCOJJ<T>(T MIALAMIFNLM) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x34C8480", Offset = "0x34C6A80", VA = "0x1834C8480")]
	private static T KOOOLLKEHFJ<T>(MessageParser<T> KBFPIODOOCM, byte[] MIALAMIFNLM, T HILNFBANAMD) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4CA0", Offset = "0x7CE32A0", VA = "0x187CE4CA0")]
	[AsyncStateMachine(typeof(NCKNDJNPJML))]
	private Task<FJGBFJOGCIJ.FACBLMDCNMH<KKBOOBAMIML>> PCKNOIEGACI(KKBOOBAMIML FNHJGBHLJLO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x34C85D0", Offset = "0x34C6BD0", VA = "0x1834C85D0")]
	[AsyncStateMachine(typeof(HBCAOHKJCEE<>))]
	internal Task<T> LHHBGMDAJAO<T>(CancellationToken DGLOFFGGICM, Func<CancellationToken, Task<T>> PAOHIJCDFLP, int GCINMLANHNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CE47B0", Offset = "0x7CE2DB0", VA = "0x187CE47B0")]
	[AsyncStateMachine(typeof(JOICGPPBBAI))]
	internal Task LHHBGMDAJAO(CancellationToken DGLOFFGGICM, Func<CancellationToken, Task> PAOHIJCDFLP, int GCINMLANHNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4AC0", Offset = "0x7CE30C0", VA = "0x187CE4AC0")]
	public MDEFBAINCHB OIOHKCCICJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4A40", Offset = "0x7CE3040", VA = "0x187CE4A40")]
	public FGCFMBILFGM NHGHOCKAECB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3E00", Offset = "0x7CE2400", VA = "0x187CE3E00")]
	public IBCNCFMBDFO CDHJOJFGMBD([Optional] IBCMILIKEJG? DDKJAEALMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7CE48E0", Offset = "0x7CE2EE0", VA = "0x187CE48E0")]
	public void NAKHPHKCGKF(Func<Guid, bool> PKCGFPJGAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CE46A0", Offset = "0x7CE2CA0", VA = "0x187CE46A0")]
	public void KDPLFFCCIFC(Func<Guid, bool> KOGBGLOGAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4190", Offset = "0x7CE2790", VA = "0x187CE4190")]
	public Guid FKBAAGJCFKA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4B90", Offset = "0x7CE3190", VA = "0x187CE4B90")]
	public void OMBHMMCDFMM(Guid LDIJEIIPGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4DE0", Offset = "0x7CE33E0", VA = "0x187CE4DE0")]
	public void PHHOOCMICLB(KKBOOBAMIML EGKHLAKCBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4430", Offset = "0x7CE2A30", VA = "0x187CE4430")]
	public void IEGNOINNOMJ(string ELPDJAJBGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x34C8390", Offset = "0x34C6990", VA = "0x1834C8390")]
	private T ECDIJKIJKOB<T>(T KBGCCIOIGBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4B40", Offset = "0x7CE3140", VA = "0x187CE4B40")]
	public void OKHKDMFIAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x34C8880", Offset = "0x34C6E80", VA = "0x1834C8880")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IINANFOELCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CDF800", Offset = "0x7CDDE00", VA = "0x187CDF800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE9480", Offset = "0x7CE7A80", VA = "0x187CE9480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9DD0", Offset = "0x7CE83D0", VA = "0x187CE9DD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD70F0", Offset = "0x7CD56F0", VA = "0x187CD70F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CD7820", Offset = "0x7CD5E20", VA = "0x187CD7820", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CECA80", Offset = "0x7CEB080", VA = "0x187CECA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CECD90", Offset = "0x7CEB390", VA = "0x187CECD90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HIGMCIBJAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CDEDA0", Offset = "0x7CDD3A0", VA = "0x187CDEDA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CEDBD0", Offset = "0x7CEC1D0", VA = "0x187CEDBD0")]
	public PENMICHADGI(HLOJEJEEEIJ JIPCODKNIPN, GDBFIEIFOFD BIHCMIGBKEI, Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x7CED7A0", Offset = "0x7CEBDA0", VA = "0x187CED7A0", Slot = "7")]
	[AsyncStateMachine(typeof(OEBHGCCDMBG))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CED9F0", Offset = "0x7CEBFF0", VA = "0x187CED9F0")]
	[AsyncStateMachine(typeof(CDIJBOJGCND))]
	private Task JBCADINJCCP(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7CED8E0", Offset = "0x7CEBEE0", VA = "0x187CED8E0")]
	[AsyncStateMachine(typeof(OMLFMLDFDLD))]
	private Task<int> GNEHCNEIMKK(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CED5C0", Offset = "0x7CEBBC0", VA = "0x187CED5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD66F0", Offset = "0x7CD4CF0", VA = "0x187CD66F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CD7090", Offset = "0x7CD5690", VA = "0x187CD7090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ABD0", VA = "0x18095C5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x95C500", Offset = "0x95AB00", VA = "0x18095C500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6540", Offset = "0x7CD4B40", VA = "0x187CD6540")]
	public BIPDBNACGLK(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, int KGLJBMKFNLO, JICNBBCNCAC HNGPDEBEPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6420", Offset = "0x7CD4A20", VA = "0x187CD6420", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JPFEDBODOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1150", Offset = "0x7CDF750", VA = "0x187CE1150")]
		internal Task OOBOACCBIEH(FGFDKLMANEA<string>.ICBJPFEBGDJ postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE10C0", Offset = "0x7CDF6C0", VA = "0x187CE10C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDBB40", Offset = "0x7CDA140", VA = "0x187CDBB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CDC310", Offset = "0x7CDA910", VA = "0x187CDC310", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDE0A0", Offset = "0x7CDC6A0", VA = "0x187CDE0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CDE650", Offset = "0x7CDCC50", VA = "0x187CDE650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8C10", Offset = "0x7CD7210", VA = "0x187CD8C10")]
	public DLAAIOANIIA(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, string KEFEFOJNANB, FDFGBGCLFKC MNGFNEKIDGN, bool JMBMPMPJDFC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8990", Offset = "0x7CD6F90", VA = "0x187CD8990", Slot = "7")]
	[AsyncStateMachine(typeof(GEPOOGAIJGK))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task CGEGANKPCOH(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8AD0", Offset = "0x7CD70D0", VA = "0x187CD8AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDE7D0", Offset = "0x7CDCDD0", VA = "0x187CDE7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CDED40", Offset = "0x7CDD340", VA = "0x187CDED40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly DPOOOLNKMNK KEGDNPBCBNK;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE000", Offset = "0x7CDC600", VA = "0x187CDE000")]
	public HBHOPKPPHAM(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, DPOOOLNKMNK KEGDNPBCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDF20", Offset = "0x7CDC520", VA = "0x187CDDF20", Slot = "6")]
	protected override string DKGFFAOJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDE00", Offset = "0x7CDC400", VA = "0x187CDDE00", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KIGIDJNPHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1190", Offset = "0x7CDF790", VA = "0x187CE1190")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public APIKNLCDIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7CD4200", Offset = "0x7CD2800", VA = "0x187CD4200")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE13A0", Offset = "0x7CDF9A0", VA = "0x187CE13A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2560", Offset = "0x7CE0B60", VA = "0x187CE2560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CEAE10", Offset = "0x7CE9410", VA = "0x187CEAE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB8B0", Offset = "0x7CE9EB0", VA = "0x187CEB8B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE2820", Offset = "0x7CE0E20", VA = "0x187CE2820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2B80", Offset = "0x7CE1180", VA = "0x187CE2B80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD2D0", Offset = "0x7CDB8D0", VA = "0x187CDD2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public JBCPMCBEPKG AABBPKBJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD8F0", Offset = "0x7CDBEF0", VA = "0x187CDD8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD4A0", Offset = "0x7CDBAA0", VA = "0x187CDD4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LLLEILNOHAD DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD7D0", Offset = "0x7CDBDD0", VA = "0x187CDD7D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD690", Offset = "0x7CDBC90", VA = "0x187CDD690", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD940", Offset = "0x7CDBF40", VA = "0x187CDD940")]
	protected GPIPDBGGDOE(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, string KEFEFOJNANB, FDFGBGCLFKC MNGFNEKIDGN, bool JMBMPMPJDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD010", Offset = "0x7CDB610", VA = "0x187CDD010", Slot = "6")]
	protected virtual string DKGFFAOJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD270", Offset = "0x7CDB870", VA = "0x187CDD270")]
	public void HCLIDNPLDDC(ILHKDDEOLFL KBKNECNKOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD670", Offset = "0x7CDBC70", VA = "0x187CDD670")]
	protected void JPFMKGIKMLF(float FCEAHINHNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD520", Offset = "0x7CDBB20", VA = "0x187CDD520")]
	[AsyncStateMachine(typeof(KMDEJHDFNAN))]
	public Task IKIFLPOJPIB(CancellationToken LAEIHJHNGEK, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, [Optional] Func<GPIPDBGGDOE, FGFDKLMANEA<string>.ICBJPFEBGDJ, LGACCJIPMFL> EIPJBMOCFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD140", Offset = "0x7CDB740", VA = "0x187CDD140")]
	[AsyncStateMachine(typeof(OKDNJDHAADA))]
	private static Task GJIHJCIEDLC(Func<CancellationToken, Task> AEHHMEEBAGJ, Func<CancellationToken, Task> FJOGFPABEOH, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD320", Offset = "0x7CDB920", VA = "0x187CDD320")]
	private void IADBIPKGCNN(bool JHGFMOPHGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCDE0", Offset = "0x7CDB3E0", VA = "0x187CDCDE0")]
	private void AKCOHOBDLOM(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD6B0", Offset = "0x7CDBCB0", VA = "0x187CDD6B0")]
	[AsyncStateMachine(typeof(LACOEBDHBMI))]
	private Task NHJECLABBBJ(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD7F0", Offset = "0x7CDBDF0", VA = "0x187CDD7F0")]
	public KKBOOBAMIML OBPOADBCOIG(JEBNFPBGHGM JHIDIAHPODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD050", Offset = "0x7CDB650", VA = "0x187CDD050")]
	[CompilerGenerated]
	private Task DKIKANDAKJN(CancellationToken CHBEBLKFDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD870", Offset = "0x7CDBE70", VA = "0x187CDD870")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CECE00", Offset = "0x7CEB400", VA = "0x187CECE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7CED560", Offset = "0x7CEBB60", VA = "0x187CED560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly HLOJEJEEEIJ KJMNBFJKBLK;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x7CE75F0", Offset = "0x7CE5BF0", VA = "0x187CE75F0")]
	public MNGIPKDPBOH(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, HLOJEJEEEIJ KJMNBFJKBLK, OKCNIPGMDHK PNMPBHPCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x7CE74A0", Offset = "0x7CE5AA0", VA = "0x187CE74A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE8450", Offset = "0x7CE6A50", VA = "0x187CE8450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8800", Offset = "0x7CE6E00", VA = "0x187CE8800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly string DAJOPLFHCAI;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4150", Offset = "0x7CD2750", VA = "0x187CD4150")]
	public ANEDJOBPDGC(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, string DAJOPLFHCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4040", Offset = "0x7CD2640", VA = "0x187CD4040", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CEF620", Offset = "0x7CEDC20", VA = "0x187CEF620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x7CEFAE0", Offset = "0x7CEE0E0", VA = "0x187CEFAE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BDGKHJCFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7CD42C0", Offset = "0x7CD28C0", VA = "0x187CD42C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE9E30", Offset = "0x7CE8430", VA = "0x187CE9E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEADB0", Offset = "0x7CE93B0", VA = "0x187CEADB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CE0600", Offset = "0x7CDEC00", VA = "0x187CE0600")]
	public JEDGKNBKHDA(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, int NCACHKHPMEG, ABMKIBHCAFE FPKAICKNAPP, OKCNIPGMDHK PNMPBHPCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0140", Offset = "0x7CDE740", VA = "0x187CE0140", Slot = "8")]
	[AsyncStateMachine(typeof(OEMLCFNLJKB))]
	protected override Task CGEGANKPCOH(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0280", Offset = "0x7CDE880", VA = "0x187CE0280")]
	private void HKBPNCMNCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0380", Offset = "0x7CDE980", VA = "0x187CE0380")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDB7E0", Offset = "0x7CD9DE0", VA = "0x187CDB7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB830", Offset = "0x7CD9E30", VA = "0x187CDB830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB9E0", Offset = "0x7CD9FE0", VA = "0x187CDB9E0")]
	protected GCLDIMIBKMA(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB8C0", Offset = "0x7CD9EC0", VA = "0x187CDB8C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CE51C0", Offset = "0x7CE37C0", VA = "0x187CE51C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDBA40", Offset = "0x7CDA040", VA = "0x187CDBA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBAB0", Offset = "0x7CDA0B0", VA = "0x187CDBAB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CDC930", Offset = "0x7CDAF30", VA = "0x187CDC930")]
	public static GHELAHOMIBN FKBAAGJCFKA(LGACCJIPMFL OKNMIEHKKPG)
	{
		return default(GHELAHOMIBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xFF3B70", Offset = "0xFF2170", VA = "0x180FF3B70")]
	public void JIEDCNHFBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC920", Offset = "0x7CDAF20", VA = "0x187CDC920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCC40", Offset = "0x7CDB240", VA = "0x187CDCC40")]
	private GHELAHOMIBN(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCA00", Offset = "0x7CDB000", VA = "0x187CDCA00")]
	private void OMBHMMCDFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC960", Offset = "0x7CDAF60", VA = "0x187CDC960")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDADD0", Offset = "0x7CD93D0", VA = "0x187CDADD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB6A0", Offset = "0x7CD9CA0", VA = "0x187CDB6A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE08F0", Offset = "0x7CDEEF0", VA = "0x187CE08F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7CE0D20", Offset = "0x7CDF320", VA = "0x187CE0D20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD7DA0", Offset = "0x7CD63A0", VA = "0x187CD7DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD83E0", Offset = "0x7CD69E0", VA = "0x187CD83E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CEE7B0", Offset = "0x7CECDB0", VA = "0x187CEE7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x7CEEF10", Offset = "0x7CED510", VA = "0x187CEEF10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CEEF80", Offset = "0x7CED580", VA = "0x187CEEF80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x7CEF5B0", Offset = "0x7CEDBB0", VA = "0x187CEF5B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public INGLBPKFLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFEA0", Offset = "0x7CDE4A0", VA = "0x187CDFEA0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<GCMEINGJNIC> LCDMLBLIDPG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFC20", Offset = "0x7CDE220", VA = "0x187CDFC20")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<BPPINHJEEIJ> EKPPCONECJK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFBE0", Offset = "0x7CDE1E0", VA = "0x187CDFBE0")]
		internal void CJJEKKNJNOK(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFD40", Offset = "0x7CDE340", VA = "0x187CDFD40")]
		internal Task JMFHKLMAKKL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFFE0", Offset = "0x7CDE5E0", VA = "0x187CDFFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE76A0", Offset = "0x7CE5CA0", VA = "0x187CE76A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE83F0", Offset = "0x7CE69F0", VA = "0x187CE83F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CEB910", Offset = "0x7CE9F10", VA = "0x187CEB910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x7CECA20", Offset = "0x7CEB020", VA = "0x187CECA20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CDEEE0", Offset = "0x7CDD4E0", VA = "0x187CDEEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7CDF7A0", Offset = "0x7CDDDA0", VA = "0x187CDF7A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CEDD60", Offset = "0x7CEC360", VA = "0x187CEDD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE6F0", Offset = "0x7CECCF0", VA = "0x187CEE6F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CE2BE0", Offset = "0x7CE11E0", VA = "0x187CE2BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3D90", Offset = "0x7CE2390", VA = "0x187CE3D90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D03600", Offset = "0x7D01C00", VA = "0x187D03600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7D04710", Offset = "0x7D02D10", VA = "0x187D04710", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D05F90", Offset = "0x7D04590", VA = "0x187D05F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7D061E0", Offset = "0x7D047E0", VA = "0x187D061E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D08130", Offset = "0x7D06730", VA = "0x187D08130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x7D08760", Offset = "0x7D06D60", VA = "0x187D08760", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DENPELLMILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF55B0", Offset = "0x7CF3BB0", VA = "0x187CF55B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF95C0", Offset = "0x7CF7BC0", VA = "0x187CF95C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9AE0", Offset = "0x7CF80E0", VA = "0x187CF9AE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF7640", Offset = "0x7CF5C40", VA = "0x187CF7640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7B90", Offset = "0x7CF6190", VA = "0x187CF7B90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFA270", Offset = "0x7CF8870", VA = "0x187CFA270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA560", Offset = "0x7CF8B60", VA = "0x187CFA560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D01700", Offset = "0x7CFFD00", VA = "0x187D01700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7D01930", Offset = "0x7CFFF30", VA = "0x187D01930", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D087D0", Offset = "0x7D06DD0", VA = "0x187D087D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x7D092A0", Offset = "0x7D078A0", VA = "0x187D092A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EGJPOAAHAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6610", Offset = "0x7CF4C10", VA = "0x187CF6610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D06750", Offset = "0x7D04D50", VA = "0x187D06750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7D07610", Offset = "0x7D05C10", VA = "0x187D07610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF46B0", Offset = "0x7CF2CB0", VA = "0x187CF46B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4AB0", Offset = "0x7CF30B0", VA = "0x187CF4AB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFE940", Offset = "0x7CFCF40", VA = "0x187CFE940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7CFEF60", Offset = "0x7CFD560", VA = "0x187CFEF60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD9BD0", Offset = "0x7CD81D0", VA = "0x187CD9BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event LLLEILNOHAD DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA920", Offset = "0x7CD8F20", VA = "0x187CDA920", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7CDA180", Offset = "0x7CD8780", VA = "0x187CDA180", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAB10", Offset = "0x7CD9110", VA = "0x187CDAB10")]
	public FGCFMBILFGM(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9900", Offset = "0x7CD7F00", VA = "0x187CD9900")]
	[AsyncStateMachine(typeof(FPAEEOGCNCA))]
	public Task HLJJAOICHFK(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA4D0", Offset = "0x7CD8AD0", VA = "0x187CDA4D0")]
	[AsyncStateMachine(typeof(JJKCOMFENNJ))]
	private Task<KKBOOBAMIML> MJJIEBHIBFO(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9620", Offset = "0x7CD7C20", VA = "0x187CD9620")]
	[AsyncStateMachine(typeof(CPNGJGEOCEP))]
	private Task EPGCMAPHDKD(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA7E0", Offset = "0x7CD8DE0", VA = "0x187CDA7E0")]
	[AsyncStateMachine(typeof(MPBAMBDIBDA))]
	private Task NPBJMOLKGPF(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken NNLILNGJPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9E70", Offset = "0x7CD8470", VA = "0x187CD9E70")]
	[AsyncStateMachine(typeof(OKHFNBIIBLG))]
	private Task KIKDPAONNLJ(BPPINHJEEIJ PIMCENOPMKL, DFIENIKFOMH EBIAFJLALFJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken BFGLMGKCPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA340", Offset = "0x7CD8940", VA = "0x187CDA340")]
	[AsyncStateMachine(typeof(HJPHBLIGJJK))]
	private Task MIBJENBLHOH(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA1A0", Offset = "0x7CD87A0", VA = "0x187CDA1A0")]
	[AsyncStateMachine(typeof(PMNOIEPGIOC))]
	private Task MDEOJHFIHDL(BPPINHJEEIJ GIDGOODJFLJ, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7CD97A0", Offset = "0x7CD7DA0", VA = "0x187CD97A0")]
	[AsyncStateMachine(typeof(LDEILIPBMHG))]
	private Task<JBLLOOMMFJC> GOGCEKMEDOC(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9CF0", Offset = "0x7CD82F0", VA = "0x187CD9CF0")]
	[AsyncStateMachine(typeof(OCEINLAHINN))]
	private Task<JBLLOOMMFJC> KEAMDFDOMIK(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9A50", Offset = "0x7CD8050", VA = "0x187CD9A50")]
	[AsyncStateMachine(typeof(PAFBBLAODGC))]
	private Task<JBLLOOMMFJC> ILBJHGKIOOB(JBLLOOMMFJC FFFGJNJFNPO, BPPINHJEEIJ CAILOKLPAOE, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool LKEGNGJABPA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9200", Offset = "0x7CD7800", VA = "0x187CD9200")]
	private bool BBDNDNJLMAI(BPPINHJEEIJ PIMCENOPMKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA630", Offset = "0x7CD8C30", VA = "0x187CDA630")]
	[AsyncStateMachine(typeof(HKEOMNKAFIF))]
	protected Task<JBLLOOMMFJC> MMPIDAMILLK(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, IKABHLDKEMD EDMEMLGNACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA030", Offset = "0x7CD8630", VA = "0x187CDA030")]
	[AsyncStateMachine(typeof(FGIGPNOKIPL))]
	private Task LFLJKGJIFLE(BPPINHJEEIJ GIDGOODJFLJ, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9FE0", Offset = "0x7CD85E0", VA = "0x187CD9FE0")]
	private void LAKFIGOGGEA(JBLLOOMMFJC BMKIBAJMELF, DFIENIKFOMH FKKJJFDOIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9760", Offset = "0x7CD7D60", VA = "0x187CD9760")]
	private void GMLBHCNBHKF(JBLLOOMMFJC JIDEPALIAMB, [Out] JBLLOOMMFJC PBMPENMHACB, [Out] JBLLOOMMFJC FOGDCDFNADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x7CD95E0", Offset = "0x7CD7BE0", VA = "0x187CD95E0")]
	private Task<GCMEINGJNIC> EDOFDHBENFM(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA970", Offset = "0x7CD8F70", VA = "0x187CDA970")]
	private Task<BPPINHJEEIJ> PKGILMEBEND(GCMEINGJNIC GIDGOODJFLJ, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9490", Offset = "0x7CD7A90", VA = "0x187CD9490")]
	[AsyncStateMachine(typeof(IBNPCIHKGLE))]
	private Task EBLPKLKMBAA(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool KOHAADJPPJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9C00", Offset = "0x7CD8200", VA = "0x187CD9C00")]
	[AsyncStateMachine(typeof(LHDAJBHHCPJ))]
	private Task JLKOHEHLGDH(BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA940", Offset = "0x7CD8F40", VA = "0x187CDA940")]
	private Task OPCMJDDFHEG(BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9470", Offset = "0x7CD7A70", VA = "0x187CD9470")]
	private Task EBGGFAHLEHK(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7CD92F0", Offset = "0x7CD78F0", VA = "0x187CD92F0")]
	private Task BNEFMJCNHNK(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x7CD91E0", Offset = "0x7CD77E0", VA = "0x187CD91E0")]
	private Task ALEIPHLEHPD(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAB00", Offset = "0x7CD9100", VA = "0x187CDAB00")]
	private static Task POADKFJFFAF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA7C0", Offset = "0x7CD8DC0", VA = "0x187CDA7C0")]
	private Task NKBNBONLINP(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9FC0", Offset = "0x7CD85C0", VA = "0x187CD9FC0")]
	private Task KOHCDBOFGDH(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA2F0", Offset = "0x7CD88F0", VA = "0x187CDA2F0")]
	private void MGMDMHKNICO(HLOJEJEEEIJ NEMAHPGAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9130", Offset = "0x7CD7730", VA = "0x187CD9130")]
	public void AJLKPLHCNKL(long KGGKGOKAJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void HMIJIKMAHNE(EPDFKONBMMJ OCNEFBOFEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA9B0", Offset = "0x7CD8FB0", VA = "0x187CDA9B0")]
	[AsyncStateMachine(typeof(PFMIFLEFIKD))]
	private Task PKHPKIJMBFE(BPPINHJEEIJ PIMCENOPMKL, DFIENIKFOMH EBIAFJLALFJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken BFGLMGKCPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8FF0", Offset = "0x7CD75F0", VA = "0x187CD8FF0")]
	[AsyncStateMachine(typeof(CCCNIHCEGEH))]
	private Task AJLGILJEAIF(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA450", Offset = "0x7CD8A50", VA = "0x187CDA450")]
	private static PLEGJMDHKHI MIEEPACHJJG(BPPINHJEEIJ CAILOKLPAOE)
	{
		return default(PLEGJMDHKHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9310", Offset = "0x7CD7910", VA = "0x187CD9310")]
	[AsyncStateMachine(typeof(KOGFPPICJJK))]
	private Task<JBLLOOMMFJC> DEHKOKIPEME(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D051B0", Offset = "0x7D037B0", VA = "0x187D051B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7D05200", Offset = "0x7D03800", VA = "0x187D05200")]
	public static Task IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D052E0", Offset = "0x7D038E0", VA = "0x187D052E0")]
	private void IKIFLPOJPIB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct IMLKNBPEINN
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CFBE60", Offset = "0x7CFA460", VA = "0x187CFBE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFBF40", Offset = "0x7CFA540", VA = "0x187CFBF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7CFC470", Offset = "0x7CFAA70", VA = "0x187CFC470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6770", Offset = "0x7CF4D70", VA = "0x187CF6770")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D025D0", Offset = "0x7D00BD0", VA = "0x187D025D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D032B0", Offset = "0x7D018B0", VA = "0x187D032B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2670", Offset = "0x7CF0C70", VA = "0x187CF2670")]
	[AsyncStateMachine(typeof(NNPCNOADPOI))]
	public static Task IKIFLPOJPIB(LGACCJIPMFL OKNMIEHKKPG, BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CF27C0", Offset = "0x7CF0DC0", VA = "0x187CF27C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF8F40", Offset = "0x7CF7540", VA = "0x187CF8F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9560", Offset = "0x7CF7B60", VA = "0x187CF9560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDAA0", Offset = "0x7CFC0A0", VA = "0x187CFDAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFD830", Offset = "0x7CFBE30", VA = "0x187CFD830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDA40", Offset = "0x7CFC040", VA = "0x187CFDA40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D09630", Offset = "0x7D07C30", VA = "0x187D09630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D099C0", Offset = "0x7D07FC0", VA = "0x187D099C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EMOIKIACKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7CF68B0", Offset = "0x7CF4EB0", VA = "0x187CF68B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF69D0", Offset = "0x7CF4FD0", VA = "0x187CF69D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CF75E0", Offset = "0x7CF5BE0", VA = "0x187CF75E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KOIMGGHMCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CFF080", Offset = "0x7CFD680", VA = "0x187CFF080")]
		internal object GLGHHHOPFBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CFEFD0", Offset = "0x7CFD5D0", VA = "0x187CFEFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFABA0", Offset = "0x7CF91A0", VA = "0x187CFABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7CFABF0", Offset = "0x7CF91F0", VA = "0x187CFABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAC90", Offset = "0x7CF9290", VA = "0x187CFAC90")]
	[AsyncStateMachine(typeof(JOPOBHHCMFP))]
	public static Task IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ, LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool KOHAADJPPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CFADE0", Offset = "0x7CF93E0", VA = "0x187CFADE0")]
	[AsyncStateMachine(typeof(FDPBAMLECPK))]
	private Task IKIFLPOJPIB(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAF50", Offset = "0x7CF9550", VA = "0x187CFAF50")]
	private void OCBDKNNMIGL([NotNull] BDHMMMHCHAA HKMOFGELBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CFAF10", Offset = "0x7CF9510", VA = "0x187CFAF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF19D0", Offset = "0x7CEFFD0", VA = "0x187CF19D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CF2510", Offset = "0x7CF0B10", VA = "0x187CF2510", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF7C40", Offset = "0x7CF6240", VA = "0x187CF7C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8260", Offset = "0x7CF6860", VA = "0x187CF8260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF0E90", Offset = "0x7CEF490", VA = "0x187CF0E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1440", Offset = "0x7CEFA40", VA = "0x187CF1440", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CF2D20", Offset = "0x7CF1320", VA = "0x187CF2D20")]
	public static Task<BPPINHJEEIJ> IJFMDAEMJDO(CFEMEJBKCKD GHFCFJHMPHJ, [In] GCMEINGJNIC GIDGOODJFLJ, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3100", Offset = "0x7CF1700", VA = "0x187CF3100")]
	[AsyncStateMachine(typeof(BBBHFDHBKDN))]
	private Task<BPPINHJEEIJ> IKIFLPOJPIB(POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CF29C0", Offset = "0x7CF0FC0", VA = "0x187CF29C0")]
	[AsyncStateMachine(typeof(GECIHKCMICD))]
	private Task<JOFBNNGKBOO<GNOIADKGAKA, PGAGFEIEKID>> DFCFPGOPLNJ(string HDFGNIINOHH, long KGGKGOKAJFO, long? FFFLOIOFAMB, long? GHFFAIKCNFL, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, FGFDKLMANEA<string>.ICBJPFEBGDJ NLMHFHFIGIO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2B90", Offset = "0x7CF1190", VA = "0x187CF2B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D04D30", Offset = "0x7D03330", VA = "0x187D04D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D05140", Offset = "0x7D03740", VA = "0x187D05140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF82D0", Offset = "0x7CF68D0", VA = "0x187CF82D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8700", Offset = "0x7CF6D00", VA = "0x187CF8700", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JFHEOIOBIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xCFA4F0", Offset = "0xCF8AF0", VA = "0x180CFA4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFF160", Offset = "0x7CFD760", VA = "0x187CFF160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D003C0", Offset = "0x7CFE9C0", VA = "0x187D003C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CFE580", Offset = "0x7CFCB80", VA = "0x187CFE580")]
	public static Task<GCMEINGJNIC> IJFMDAEMJDO(CFEMEJBKCKD GHFCFJHMPHJ, HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE7C0", Offset = "0x7CFCDC0", VA = "0x187CFE7C0")]
	[AsyncStateMachine(typeof(OLKFNHNCLHP))]
	private Task<GCMEINGJNIC> IKIFLPOJPIB(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE280", Offset = "0x7CFC880", VA = "0x187CFE280")]
	[AsyncStateMachine(typeof(GEEPJBIJNIK))]
	private Task<GCMEINGJNIC> EDOFDHBENFM(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE3E0", Offset = "0x7CFC9E0", VA = "0x187CFE3E0")]
	[AsyncStateMachine(typeof(LANGGNJPCMC))]
	private static Task<GCMEINGJNIC> EDOFDHBENFM(JJKJBCNAAJM MOKEOOADLAP, MLDPBHLIHNF OOAHFJPLOHB, long FFFLOIOFAMB, long OGHBKCHPPKA, long AFCAJMDPILG, string BPPPCIKOLON, DDDGOPGHMJC PKCCECPMCHO, CancellationToken LAEIHJHNGEK, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE910", Offset = "0x7CFCF10", VA = "0x187CFE910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D07670", Offset = "0x7D05C70", VA = "0x187D07670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D07C00", Offset = "0x7D06200", VA = "0x187D07C00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CFDD20", Offset = "0x7CFC320", VA = "0x187CFDD20")]
	public static Task GBNLLEDCFPD(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDEC0", Offset = "0x7CFC4C0", VA = "0x187CFDEC0")]
	[AsyncStateMachine(typeof(PPJENAMIEIF))]
	public Task IKIFLPOJPIB(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDBC0", Offset = "0x7CFC1C0", VA = "0x187CFDBC0")]
	private static void BFGNOPBDEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CFE0A0", Offset = "0x7CFC6A0", VA = "0x187CFE0A0")]
	private void LEFHIPAGEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDFE0", Offset = "0x7CFC5E0", VA = "0x187CFDFE0")]
	private static float IPFNBKLAGGC(JJKJBCNAAJM MOKEOOADLAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CFDD00", Offset = "0x7CFC300", VA = "0x187CFDD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFC760", Offset = "0x7CFAD60", VA = "0x187CFC760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x7CFCF80", Offset = "0x7CFB580", VA = "0x187CFCF80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D00430", Offset = "0x7CFEA30", VA = "0x187D00430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D00760", Offset = "0x7CFED60", VA = "0x187D00760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D03440", Offset = "0x7D01A40", VA = "0x187D03440")]
	[AsyncStateMachine(typeof(JCAFBGBAAAM))]
	public static Task IKIFLPOJPIB(LGACCJIPMFL OKNMIEHKKPG, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D033D0", Offset = "0x7D019D0", VA = "0x187D033D0")]
	private static Task<KKBOOBAMIML> BHHHALGGDHI(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D03310", Offset = "0x7D01910", VA = "0x187D03310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFCFE0", Offset = "0x7CFB5E0", VA = "0x187CFCFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CFD690", Offset = "0x7CFBC90", VA = "0x187CFD690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OAMNBDFGDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D03580", Offset = "0x7D01B80", VA = "0x187D03580")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF4B10", Offset = "0x7CF3110", VA = "0x187CF4B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4F90", Offset = "0x7CF3590", VA = "0x187CF4F90", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CFC600", Offset = "0x7CFAC00", VA = "0x187CFC600")]
	public static Task HMHPKIGMEPC(CFEMEJBKCKD GHFCFJHMPHJ, bool IOHINMLPMHA, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken ENHKOFNDDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CFC670", Offset = "0x7CFAC70", VA = "0x187CFC670")]
	[AsyncStateMachine(typeof(JLCFBCJKDJC))]
	private Task IKIFLPOJPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CFC4D0", Offset = "0x7CFAAD0", VA = "0x187CFC4D0")]
	[AsyncStateMachine(typeof(CDJKDCPMFPI))]
	private Task GGDDPFFOFAN(bool KFJFEEGFJLE, string GOCBDOMNJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFA5C0", Offset = "0x7CF8BC0", VA = "0x187CFA5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CFAB30", Offset = "0x7CF9130", VA = "0x187CFAB30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FGOLLNBFJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7BF0", Offset = "0x7CF61F0", VA = "0x187CF7BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D06250", Offset = "0x7D04850", VA = "0x187D06250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7D066E0", Offset = "0x7D04CE0", VA = "0x187D066E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D02410", Offset = "0x7D00A10", VA = "0x187D02410")]
	public static Task<Scene> MPJHANNLHGP(CFEMEJBKCKD GHFCFJHMPHJ, HJFMPFKHBLD DODKGJGBFEC, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7D022F0", Offset = "0x7D008F0", VA = "0x187D022F0")]
	[AsyncStateMachine(typeof(ICOAJFPDOAO))]
	private Task<Scene> IKIFLPOJPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D02100", Offset = "0x7D00700", VA = "0x187D02100")]
	private bool CHHAFFJHKBB(BPPINHJEEIJ GIDGOODJFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D02280", Offset = "0x7D00880", VA = "0x187D02280")]
	private void GLJCJOCHJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7D02130", Offset = "0x7D00730", VA = "0x187D02130")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF3890", Offset = "0x7CF1E90", VA = "0x187CF3890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4360", Offset = "0x7CF2960", VA = "0x187CF4360", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF0B40", Offset = "0x7CEF140", VA = "0x187CF0B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0E20", Offset = "0x7CEF420", VA = "0x187CF0E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x629B350", Offset = "0x6299950", VA = "0x18629B350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x7CF03B0", Offset = "0x7CEE9B0", VA = "0x187CF03B0")]
	public ABJDDLLLNDI(LGACCJIPMFL OKNMIEHKKPG, MBLNBFNLDAN CHKICNMGPAD, LFMOOOFFMNB AIBFBNBKOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0200", Offset = "0x7CEE800", VA = "0x187CF0200")]
	[AsyncStateMachine(typeof(CAIFKHACGJE))]
	public Task<JBLLOOMMFJC> KIBOEBIHJFN(JBLLOOMMFJC GMJCBGCLJND, BPPINHJEEIJ CAILOKLPAOE, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool LKEGNGJABPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0080", Offset = "0x7CEE680", VA = "0x187CF0080")]
	[AsyncStateMachine(typeof(ADCJKBGLBIB))]
	private Task<JBLLOOMMFJC> HMJLCOPDNIG(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, JBLLOOMMFJC CEGAGHAOIDD, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0380", Offset = "0x7CEE980", VA = "0x187CF0380")]
	private bool LKGGLPPALPF(JBLLOOMMFJC NKDAOEOIAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x7CF01E0", Offset = "0x7CEE7E0", VA = "0x187CF01E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF0410", Offset = "0x7CEEA10", VA = "0x187CF0410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0AE0", Offset = "0x7CEF0E0", VA = "0x187CF0AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x7D02490", Offset = "0x7D00A90", VA = "0x187D02490")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF5CD0", Offset = "0x7CF42D0", VA = "0x187CF5CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x7CF65B0", Offset = "0x7CF4BB0", VA = "0x187CF65B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7CFD6F0", Offset = "0x7CFBCF0", VA = "0x187CFD6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KJCPGMBCPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x7CFE200", Offset = "0x7CFC800", VA = "0x187CFE200")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D05C80", Offset = "0x7D04280", VA = "0x187D05C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7D05F30", Offset = "0x7D04530", VA = "0x187D05F30")]
	public static FNBHKFLEHND IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ)
	{
		return default(FNBHKFLEHND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x7D05CD0", Offset = "0x7D042D0", VA = "0x187D05CD0")]
	private FNBHKFLEHND IKIFLPOJPIB()
	{
		return default(FNBHKFLEHND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x7D05500", Offset = "0x7D03B00", VA = "0x187D05500")]
	private FNBHKFLEHND ABJJGLOKFAF(BDHMMMHCHAA HKMOFGELBFL, GPALOJEHCIG MCCHAEKDNLN)
	{
		return default(FNBHKFLEHND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x7D05AB0", Offset = "0x7D040B0", VA = "0x187D05AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IBEEIIHDFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA1C0", Offset = "0x7CF87C0", VA = "0x187CFA1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CPDOOMDMNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5520", Offset = "0x7CF3B20", VA = "0x187CF5520")]
		internal object MMEEHMDAIMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7D04780", Offset = "0x7D02D80", VA = "0x187D04780")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF8770", Offset = "0x7CF6D70", VA = "0x187CF8770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8EE0", Offset = "0x7CF74E0", VA = "0x187CF8EE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D09310", Offset = "0x7D07910", VA = "0x187D09310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x7D095D0", Offset = "0x7D07BD0", VA = "0x187D095D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BBNDJLHDNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF2580", Offset = "0x7CF0B80", VA = "0x187CF2580")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF56D0", Offset = "0x7CF3CD0", VA = "0x187CF56D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5C00", Offset = "0x7CF4200", VA = "0x187CF5C00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF9B50", Offset = "0x7CF8150", VA = "0x187CF9B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA160", Offset = "0x7CF8760", VA = "0x187CFA160", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D01990", Offset = "0x7CFFF90", VA = "0x187D01990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x7D02030", Offset = "0x7D00630", VA = "0x187D02030", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D07C60", Offset = "0x7D06260", VA = "0x187D07C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x7D080D0", Offset = "0x7D066D0", VA = "0x187D080D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CAPLOJBNILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7CF43D0", Offset = "0x7CF29D0", VA = "0x187CF43D0")]
		internal object AJDOPPONGMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF45B0", Offset = "0x7CF2BB0", VA = "0x187CF45B0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task JHEDCHADCOD(EOAHMNKFLEL handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7CF44C0", Offset = "0x7CF2AC0", VA = "0x187CF44C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF4FF0", Offset = "0x7CF35F0", VA = "0x187CF4FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7CF54C0", Offset = "0x7CF3AC0", VA = "0x187CF54C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF3270", Offset = "0x7CF1870", VA = "0x187CF3270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3830", Offset = "0x7CF1E30", VA = "0x187CF3830", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EALPEFEHKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5C60", Offset = "0x7CF4260", VA = "0x187CF5C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CF14B0", Offset = "0x7CEFAB0", VA = "0x187CF14B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1970", Offset = "0x7CEFF70", VA = "0x187CF1970", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MNNJPHEHPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7D02090", Offset = "0x7D00690", VA = "0x187D02090")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CFB7C0", Offset = "0x7CF9DC0", VA = "0x187CFB7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7CFBE00", Offset = "0x7CFA400", VA = "0x187CFBE00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PELHHICDGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7D15560", Offset = "0x7D13B60", VA = "0x187D15560")]
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
		[Cpp2IlInjected.Address(RVA = "0xF17660", Offset = "0xF15C60", VA = "0x180F17660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public LFMOOOFFMNB(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x7D01010", Offset = "0x7CFF610", VA = "0x187D01010")]
	[AsyncStateMachine(typeof(GJFGBPBKBCM))]
	public Task IKIFLPOJPIB(JBLLOOMMFJC FFFGJNJFNPO, BPPINHJEEIJ CAILOKLPAOE, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x7D00ED0", Offset = "0x7CFF4D0", VA = "0x187D00ED0")]
	[AsyncStateMachine(typeof(DNGOBEBLOOD))]
	private Task HPJHCBIIJAL(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x7D013E0", Offset = "0x7CFF9E0", VA = "0x187D013E0")]
	[AsyncStateMachine(typeof(HOHOIPBOJDC))]
	private Task OGLEGCHEMFJ(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x7D00B00", Offset = "0x7CFF100", VA = "0x187D00B00")]
	[AsyncStateMachine(typeof(MBDFAHFMOHF))]
	private Task HIMJIGMOCED(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x7D007C0", Offset = "0x7CFEDC0", VA = "0x187D007C0")]
	[AsyncStateMachine(typeof(CHIHCPIMGMH))]
	private Task DJOJDIGHEKD(Guid NDLJCCHDEKE, List<EOAHMNKFLEL> GKJNMMLEIOL, BPDPCIOHIIP ELMNEDJBDIL, BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x7D009C0", Offset = "0x7CFEFC0", VA = "0x187D009C0")]
	[AsyncStateMachine(typeof(BPOHHKKEMAK))]
	private Task EPILDHPEOHI(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7D012A0", Offset = "0x7CFF8A0", VA = "0x187D012A0")]
	[AsyncStateMachine(typeof(APKEGGHJCKP))]
	private Task JLJABKJDFFA(Guid CCLPBBEIOKN, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7D01160", Offset = "0x7CFF760", VA = "0x187D01160")]
	[AsyncStateMachine(typeof(IKKFFLBEOGP))]
	private Task JJILKMOMMIE(Guid CCLPBBEIOKN, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C40", Offset = "0x7CFF240", VA = "0x187D00C40")]
	private void HNPOGBDJAJD(Guid CCLPBBEIOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7D00910", Offset = "0x7CFEF10", VA = "0x187D00910")]
	private void ENJIINKEBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x7D00D60", Offset = "0x7CFF360", VA = "0x187D00D60")]
	public Guid HPBBMFOLHML(JBLLOOMMFJC BMKIBAJMELF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7D01520", Offset = "0x7CFFB20", VA = "0x187D01520")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0A880", Offset = "0x7D08E80", VA = "0x187D0A880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AF20", Offset = "0x7D09520", VA = "0x187D0AF20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0CE70", Offset = "0x7D0B470", VA = "0x187D0CE70")]
	public static Task EFNPPBJIOOC(JJKJBCNAAJM MOKEOOADLAP, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken ENHKOFNDDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CEE0", Offset = "0x7D0B4E0", VA = "0x187D0CEE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x27743C0", Offset = "0x27729C0", VA = "0x1827743C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0D1A0", Offset = "0x7D0B7A0", VA = "0x187D0D1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IReadOnlyDictionary<long, int> HECLMEPIEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D1C0", Offset = "0x7D0B7C0", VA = "0x187D0D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D1E0", Offset = "0x7D0B7E0", VA = "0x187D0D1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0AF80", Offset = "0x7D09580", VA = "0x187D0AF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B5F0", Offset = "0x7D09BF0", VA = "0x187D0B5F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PDCGKPFNIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7D15350", Offset = "0x7D13950", VA = "0x187D15350")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0C2D0", Offset = "0x7D0A8D0", VA = "0x187D0C2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7D0CDA0", Offset = "0x7D0B3A0", VA = "0x187D0CDA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D10060", Offset = "0x7D0E660", VA = "0x187D10060")]
	public IBCNCFMBDFO(LGACCJIPMFL OKNMIEHKKPG, LDDGEGNMMJM KDNMHKOLIJK, HAHMCMAKCNH KIBHPHMJLHB, IBCMILIKEJG DDKJAEALMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FC40", Offset = "0x7D0E240", VA = "0x187D0FC40")]
	[AsyncStateMachine(typeof(CHDBBKALJAO))]
	public Task<FIHJMIFDKFO> IMJDHHAECMF(long OGHBKCHPPKA, MCIKJBCGIFM COFLABALPJG, LDLMBBIODPI OFPNBIDICMP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F620", Offset = "0x7D0DC20", VA = "0x187D0F620")]
	[AsyncStateMachine(typeof(EDFDGHKKOED))]
	private Task FGBLCCOEKLD(LDLMBBIODPI OFPNBIDICMP, PersistenceView[] ILKGDALPJFB, StringBuilder ALMMEIIBAPL, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F760", Offset = "0x7D0DD60", VA = "0x187D0F760")]
	private FIHJMIFDKFO FJLMJLDOCHN(long OGHBKCHPPKA, MCIKJBCGIFM COFLABALPJG, LDLMBBIODPI OFPNBIDICMP, IEnumerable<PersistenceView> ILKGDALPJFB, StringBuilder ALMMEIIBAPL)
	{
		return default(FIHJMIFDKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F460", Offset = "0x7D0DA60", VA = "0x187D0F460")]
	private BDHMMMHCHAA CMOABELAGEJ(long OGHBKCHPPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FDA0", Offset = "0x7D0E3A0", VA = "0x187D0FDA0")]
	private void OFGOJBEFDNG(BDHMMMHCHAA BFKCOJOKKKN, StringBuilder ALMMEIIBAPL, IEnumerable<PersistenceView> ILKGDALPJFB, [In] DONOJMBDAEC KPNKMJMEKBH, DHFOBBNDABM GNHOFHLJPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EFC0", Offset = "0x7D0D5C0", VA = "0x187D0EFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IKDJELPJCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7D100C0", Offset = "0x7D0E6C0", VA = "0x187D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0E3B0", Offset = "0x7D0C9B0", VA = "0x187D0E3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7D0EC10", Offset = "0x7D0D210", VA = "0x187D0EC10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D14C40", Offset = "0x7D13240", VA = "0x187D14C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7D152E0", Offset = "0x7D138E0", VA = "0x187D152E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0D2E0", Offset = "0x7D0B8E0", VA = "0x187D0D2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D6F0", Offset = "0x7D0BCF0", VA = "0x187D0D6F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D155D0", Offset = "0x7D13BD0", VA = "0x187D155D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x7D16550", Offset = "0x7D14B50", VA = "0x187D16550", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MIIIEPNCHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7D12310", Offset = "0x7D10910", VA = "0x187D12310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0B660", Offset = "0x7D09C60", VA = "0x187D0B660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B970", Offset = "0x7D09F70", VA = "0x187D0B970", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD9BD0", Offset = "0x7CD81D0", VA = "0x187CD9BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x7D12280", Offset = "0x7D10880", VA = "0x187D12280")]
	public MDEFBAINCHB(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x7D11C20", Offset = "0x7D10220", VA = "0x187D11C20")]
	[AsyncStateMachine(typeof(GOMHPJNBBGO))]
	private Task<(NINDCCCDADD.LJLOIGMEIFH, NINDCCCDADD.LJLOIGMEIFH)> FBGNMICBCDI(FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x7D12070", Offset = "0x7D10670", VA = "0x187D12070")]
	[AsyncStateMachine(typeof(PCHAOBIPLLG))]
	public Task<AKEHIKAMMJM> KOOJKPAIHLF(int NCACHKHPMEG, [CanBeNull] ABMKIBHCAFE FPKAICKNAPP, FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7D11F00", Offset = "0x7D10500", VA = "0x187D11F00")]
	[AsyncStateMachine(typeof(FMGFNCGMMCO))]
	private Task<HGLCHBODEAA> ILHLAHFLHMB(string BPPPCIKOLON, int NCACHKHPMEG, FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7D11D60", Offset = "0x7D10360", VA = "0x187D11D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EDC380", Offset = "0x4EDA980", VA = "0x184EDC380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC710", Offset = "0x4EDAD10", VA = "0x184EDC710")]
	internal NKKCFLLFNFP(CFEMEJBKCKD AGOLAMHOOKA, IICNNDCPJEP IJECCKDIIBB, [Optional] Guid? EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC3E0", Offset = "0x4EDA9E0", VA = "0x184EDC3E0")]
	private KKBOOBAMIML MNPGMLHIPOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	protected virtual void DBJACMLEMFH(KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC5F0", Offset = "0x4EDABF0", VA = "0x184EDC5F0")]
	public T PFKIFDFNNGO(OPHKANJGPPK EFGAKBIDOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC2E0", Offset = "0x4EDA8E0", VA = "0x184EDC2E0")]
	public T FEMOGLJGEIK(int LBCNOPPNDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC4C0", Offset = "0x4EDAAC0", VA = "0x184EDC4C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D15490", Offset = "0x7D13A90", VA = "0x187D15490")]
	internal PDOFNJJFGGG(CFEMEJBKCKD AGOLAMHOOKA, IICNNDCPJEP IJECCKDIIBB, [Optional] Guid? EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x70457D0", Offset = "0x7043DD0", VA = "0x1870457D0")]
	public PDOFNJJFGGG AOELMECGEJB(HLOJEJEEEIJ GOAPBALNOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7D153C0", Offset = "0x7D139C0", VA = "0x187D153C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0A320", Offset = "0x7D08920", VA = "0x187D0A320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7D0A6C0", Offset = "0x7D08CC0", VA = "0x187D0A6C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D13820", Offset = "0x7D11E20", VA = "0x187D13820")]
	internal NNPFBKHPJCA(CFEMEJBKCKD AGOLAMHOOKA, IICNNDCPJEP IJECCKDIIBB, [Optional] Guid? EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7D136B0", Offset = "0x7D11CB0", VA = "0x187D136B0")]
	public NNPFBKHPJCA DJNCPBLKDPA(string GPFCOHGCDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7D134E0", Offset = "0x7D11AE0", VA = "0x187D134E0")]
	public NNPFBKHPJCA CGNADFGKAJC(bool JCKIECNKFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7D13710", Offset = "0x7D11D10", VA = "0x187D13710")]
	public NNPFBKHPJCA OFJJEFAIGNB(bool AJOLOHBNOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x7D136E0", Offset = "0x7D11CE0", VA = "0x187D136E0")]
	public NNPFBKHPJCA IFHPFNHEPBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7D13500", Offset = "0x7D11B00", VA = "0x187D13500", Slot = "4")]
	protected override void DBJACMLEMFH(KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x7D13730", Offset = "0x7D11D30", VA = "0x187D13730", Slot = "5")]
	[AsyncStateMachine(typeof(BBHMFMHKIBA))]
	public override Task<GGLMIDJEDGD> PEPKCJHFKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7D13670", Offset = "0x7D11C70", VA = "0x187D13670")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D0CFD0", Offset = "0x7D0B5D0", VA = "0x187D0CFD0")]
	public static void DFFPOANJANF(this IBBHMOLEKHK HPIPDBILBFN, GDBFIEIFOFD BIHCMIGBKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D120", Offset = "0x7D0B720", VA = "0x187D0D120")]
	public static void HDACGMPKBDJ(this GDBFIEIFOFD FJKJDPBPFHP, [Optional] string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public static class BKICFDPOJFM
{
	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A7E0", Offset = "0x7D08DE0", VA = "0x187D0A7E0")]
	public static DDDGOPGHMJC CKAMLLMOOFM(this HICEPPICJKO FMPCPEMKMLL)
	{
		return default(DDDGOPGHMJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7D0A730", Offset = "0x7D08D30", VA = "0x187D0A730")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D16970", Offset = "0x7D14F70", VA = "0x187D16970")]
		public bool EPEJBEGBHOG(AOEFHBHKKHL DCLADEMODOF, [Out] ResultConfig HIGIOODIHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x7D169E0", Offset = "0x7D14FE0", VA = "0x187D169E0")]
		public ResultConfig MJADLMGCBBB(AOEFHBHKKHL CEGFAIJENKH, [Optional] HashSet<AOEFHBHKKHL> PBMABMKIGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7D170F0", Offset = "0x7D156F0", VA = "0x187D170F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7D16B20", Offset = "0x7D15120", VA = "0x187D16B20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xA447A0", Offset = "0xA42DA0", VA = "0x180A447A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D10430", Offset = "0x7D0EA30", VA = "0x187D10430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D106C0", Offset = "0x7D0ECC0", VA = "0x187D106C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D09E10", Offset = "0x7D08410", VA = "0x187D09E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D0A2C0", Offset = "0x7D088C0", VA = "0x187D0A2C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0EC80", Offset = "0x7D0D280", VA = "0x187D0EC80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EEE0", Offset = "0x7D0D4E0", VA = "0x187D0EEE0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void NADFCFLHLDK(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HGLJCKMNEBN([IBJCGEMJMJL(null)] FBFEGIANEKA GMCCMEHGAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EDD0", Offset = "0x7D0D3D0", VA = "0x187D0EDD0", Slot = "5")]
	[AsyncStateMachine(typeof(KEMGBFMHMOM))]
	public Task IKIFLPOJPIB(FGFDKLMANEA<string>.ICBJPFEBGDJ NHGJLMMOIBD, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D0ECB0", Offset = "0x7D0D2B0", VA = "0x187D0ECB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D11810", Offset = "0x7D0FE10", VA = "0x187D11810")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EIAHJNDACIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D0CE00", Offset = "0x7D0B400", VA = "0x187D0CE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D10840", Offset = "0x7D0EE40", VA = "0x187D10840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D109A0", Offset = "0x7D0EFA0", VA = "0x187D109A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	[UnityEngine.Scripting.Preserve]
	public KJGLBILIDPL([IBJCGEMJMJL(null)] LFKFODMLCGI MFGBIFDAMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D10A50", Offset = "0x7D0F050", VA = "0x187D10A50", Slot = "6")]
	public bool ICKKOCNOPIK(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xC45540", Offset = "0xC43B40", VA = "0x180C45540")]
	private void MOCNPDMEDBB(JICNBBCNCAC HNGPDEBEPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D10D40", Offset = "0x7D0F340", VA = "0x187D10D40", Slot = "7")]
	public bool IHHBEPAKLHM(long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D108F0", Offset = "0x7D0EEF0", VA = "0x187D108F0", Slot = "8")]
	public bool DONKKGDHALC(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D10EB0", Offset = "0x7D0F4B0", VA = "0x187D10EB0")]
	private void KNNKKFJNIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D10720", Offset = "0x7D0ED20", VA = "0x187D10720", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public OIOOFFGJPOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D14910", Offset = "0x7D12F10", VA = "0x187D14910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D14BF0", Offset = "0x7D131F0", VA = "0x187D14BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D14B40", Offset = "0x7D13140", VA = "0x187D14B40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JICNBBCNCAC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D14B40", Offset = "0x7D13140", VA = "0x187D14B40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GMLELOOIBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D0E310", Offset = "0x7D0C910", VA = "0x187D0E310")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LAFDGFBPBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D11790", Offset = "0x7D0FD90", VA = "0x187D11790")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D12E40", Offset = "0x7D11440", VA = "0x187D12E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D13460", Offset = "0x7D11A60", VA = "0x187D13460")]
	protected NMHGGPFAHAB([CanBeNull] string OOOIACMGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D13270", Offset = "0x7D11870", VA = "0x187D13270", Slot = "5")]
	public bool PJMAJGOOFLO(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC HNGPDEBEPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D12A40", Offset = "0x7D11040", VA = "0x187D12A40", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D12AD0", Offset = "0x7D110D0", VA = "0x187D12AD0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D12E50", Offset = "0x7D11450", VA = "0x187D12E50")]
	protected void GJDEDFAEGKC(DHLNLABPKJB.HHILMBEMCHL BCCFDDJGNMI, string OIKCDENKJMH, FileInfo AIGLCGIOEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D12EC0", Offset = "0x7D114C0", VA = "0x187D12EC0")]
	internal bool LOIEOLACGNL(FileInfo LELIODNIKJM, long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B5F060", Offset = "0x1B5D660", VA = "0x181B5F060", Slot = "8")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E2D0", Offset = "0x7D0C8D0", VA = "0x187D0E2D0")]
	public GBHOINNMDNP([Optional] string OOOIACMGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DAF0", Offset = "0x7D0C0F0", VA = "0x187D0DAF0")]
	private void FOAEMBEOIGK(DPOOOLNKMNK KEGDNPBCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D760", Offset = "0x7D0BD60", VA = "0x187D0D760", Slot = "9")]
	internal override void DLMOGAKHJCL(Stream FENEICALKKP, long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DC60", Offset = "0x7D0C260", VA = "0x187D0DC60", Slot = "10")]
	internal override bool MMFDBEOGFFA(Stream IFABEIJLFBB, long FFFLOIOFAMB, long OGHBKCHPPKA, GAGKPNJFJCJ EICEGDAOEJP, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DB70", Offset = "0x7D0C170", VA = "0x187D0DB70", Slot = "11")]
	protected override FileInfo INJAMIBBBIP(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D9F0", Offset = "0x7D0BFF0", VA = "0x187D0D9F0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x68A0300", Offset = "0x689E900", VA = "0x1868A0300", Slot = "8")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D14820", Offset = "0x7D12E20", VA = "0x187D14820")]
	public NOAJNNOBBAM([Optional] string OOOIACMGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D13990", Offset = "0x7D11F90", VA = "0x187D13990", Slot = "9")]
	internal override void DLMOGAKHJCL(Stream FENEICALKKP, long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D13F50", Offset = "0x7D12550", VA = "0x187D13F50", Slot = "10")]
	internal override bool MMFDBEOGFFA(Stream IFABEIJLFBB, long FFFLOIOFAMB, long OGHBKCHPPKA, GAGKPNJFJCJ EICEGDAOEJP, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D13D60", Offset = "0x7D12360", VA = "0x187D13D60")]
	private void EFDLGLPFIIA(byte[] HECJPBMFJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D13E20", Offset = "0x7D12420", VA = "0x187D13E20", Slot = "11")]
	protected override FileInfo INJAMIBBBIP(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D13C50", Offset = "0x7D12250", VA = "0x187D13C50", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public KKHHCFNLNHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D11700", Offset = "0x7D0FD00", VA = "0x187D11700", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D11320", Offset = "0x7D0F920", VA = "0x187D11320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D112D0", Offset = "0x7D0F8D0", VA = "0x187D112D0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D116B0", Offset = "0x7D0FCB0", VA = "0x187D116B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D11600", Offset = "0x7D0FC00", VA = "0x187D11600", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JICNBBCNCAC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D11600", Offset = "0x7D0FC00", VA = "0x187D11600", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0BE00", Offset = "0x7D0A400", VA = "0x187D0BE00", Slot = "4")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D0BF80", Offset = "0x7D0A580", VA = "0x187D0BF80")]
	[UnityEngine.Scripting.Preserve]
	public DJDKHDAADCI(params LFKFODMLCGI[] BCDNICIKMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D0BE30", Offset = "0x7D0A430", VA = "0x187D0BE30", Slot = "5")]
	public bool PJMAJGOOFLO(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC HNGPDEBEPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D0BBC0", Offset = "0x7D0A1C0", VA = "0x187D0BBC0")]
	private void GMHJOEODHKI(int OBCKKLACLKP, long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D0B9E0", Offset = "0x7D09FE0", VA = "0x187D0B9E0", Slot = "6")]
	[IteratorStateMachine(typeof(KKHHCFNLNHK))]
	public IEnumerable<JICNBBCNCAC> BPHIFMCDOJM(DPOOOLNKMNK KEGDNPBCBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D0BA70", Offset = "0x7D0A070", VA = "0x187D0BA70", Slot = "7")]
	public JICNBBCNCAC DAFLGCCMCJH(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal static class KBKIAFLFDCN
{
	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D10370", Offset = "0x7D0E970", VA = "0x187D10370")]
	internal static byte[] OFPMLOJBLCB(byte[] HECJPBMFJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D102F0", Offset = "0x7D0E8F0", VA = "0x187D102F0")]
	public static void DPJIDKDFGNB(Stream EEGCINGNJGJ, byte[] PHHEOHNFCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D10110", Offset = "0x7D0E710", VA = "0x187D10110")]
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
		[Cpp2IlInjected.Address(RVA = "0x760B8E0", Offset = "0x7609EE0", VA = "0x18760B8E0", Slot = "9")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public DateTime KAMMJIANMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x7D12440", Offset = "0x7D10A40", VA = "0x187D12440", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x7D12930", Offset = "0x7D10F30", VA = "0x187D12930")]
	public NBOLKFAMJDB(NMHGGPFAHAB PAKEKNLGDDE, FileInfo LELIODNIKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x7D12880", Offset = "0x7D10E80", VA = "0x187D12880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x7D126F0", Offset = "0x7D10CF0", VA = "0x187D126F0", Slot = "5")]
	public void FLGGKAAJILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7D127B0", Offset = "0x7D10DB0", VA = "0x187D127B0", Slot = "6")]
	public bool GMDEJNHCDGD(long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x7D124D0", Offset = "0x7D10AD0", VA = "0x187D124D0", Slot = "7")]
	public bool Equals(JICNBBCNCAC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x7D12540", Offset = "0x7D10B40", VA = "0x187D12540", Slot = "8")]
	public bool Equals(NBOLKFAMJDB OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x7D12600", Offset = "0x7D10C00", VA = "0x187D12600", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x7D127F0", Offset = "0x7D10DF0", VA = "0x187D127F0", Slot = "2")]
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
