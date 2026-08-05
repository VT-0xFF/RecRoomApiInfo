using System;
using System.Buffers;
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8598CB0", Offset = "0x85976B0", VA = "0x188598CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class ALOJOEEMFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<FKNMGFLNFFM> AGKNCFPFNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task EGHICOEKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal NEFKBOAAHCB EMFLJHMJGID;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public ALOJOEEMFDJ()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8591F50", Offset = "0x8590950", VA = "0x188591F50", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x859E540", Offset = "0x859CF40", VA = "0x18859E540", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PBIMEJJBAMF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x859A180", Offset = "0x8598B80", VA = "0x18859A180")]
	public PBIMEJJBAMF(string IJOJGNJMCGP, Exception ANDPNKJGGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class EJEHAOOMPEB : GIAOLNEPFEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KBCGHIFFFBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KNOKFGDBNBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<CDKGMGPICBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x858CDB0", Offset = "0x858B7B0", VA = "0x18858CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x858CFF0", Offset = "0x858B9F0", VA = "0x18858CFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct JJGEGHAKKBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LAHJHLANDCD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<LAHJHLANDCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x858CB30", Offset = "0x858B530", VA = "0x18858CB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x858CD40", Offset = "0x858B740", VA = "0x18858CD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[UnityEngine.Scripting.Preserve]
	public EJEHAOOMPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8580F40", Offset = "0x857F940", VA = "0x188580F40", Slot = "4")]
	[AsyncStateMachine(typeof(KBCGHIFFFBO))]
	public Task<IReadOnlyList<KNOKFGDBNBL>> EGJNNFBPJNK(long FHOIPEIAACP, long IIHAMPMIGID, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8581060", Offset = "0x857FA60", VA = "0x188581060", Slot = "5")]
	[AsyncStateMachine(typeof(JJGEGHAKKBN))]
	public Task<IReadOnlyList<LAHJHLANDCD>> NIFJGIJOMNO(IReadOnlyList<int> HNOLHMHIOBG, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OBEDBECEGGO : IEquatable<OBEDBECEGGO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JEADMECIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LAHJHLANDCD FLMIPHDCLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CFAOLMBJJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FOPNIDOJMAH? FPPGEFPDJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KJBCKNKJMLC? KNAFPNPMIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	OBFIADBCAIK IFDGANOFIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MKIOIHPBAPC> BPONJBCGIMM();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum OBFIADBCAIK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GIAOLNEPFEN
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KNOKFGDBNBL>> EGJNNFBPJNK(long FHOIPEIAACP, long IIHAMPMIGID, [Optional] CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LAHJHLANDCD>> NIFJGIJOMNO(IReadOnlyList<int> HNOLHMHIOBG, [Optional] CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BGGFHNOCGLI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class KCOAMLNCGBD : OBEDBECEGGO, IEquatable<OBEDBECEGGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct GPOOEGNPODE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public KCOAMLNCGBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private POJDIKBGDHI <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<PFLGPOLCCPC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<MKIOIHPBAPC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8588990", Offset = "0x8587390", VA = "0x188588990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8588F10", Offset = "0x8587910", VA = "0x188588F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly KNOKFGDBNBL OPICEAAMKGE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JEADMECIHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LAHJHLANDCD FLMIPHDCLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JHILFFIDEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x858D060", Offset = "0x858BA60", VA = "0x18858D060", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FOPNIDOJMAH? FPPGEFPDJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B70AC0", Offset = "0x2B6F4C0", VA = "0x182B70AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KJBCKNKJMLC? KNAFPNPMIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x858D2B0", Offset = "0x858BCB0", VA = "0x18858D2B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OBFIADBCAIK IFDGANOFIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA62010", Offset = "0xA60A10", VA = "0x180A62010", Slot = "10")]
			get
			{
				return default(OBFIADBCAIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x858D080", Offset = "0x858BA80", VA = "0x18858D080", Slot = "9")]
		[AsyncStateMachine(typeof(GPOOEGNPODE))]
		public Task<MKIOIHPBAPC> BPONJBCGIMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x858D390", Offset = "0x858BD90", VA = "0x18858D390")]
		public KCOAMLNCGBD(int BOGHGIDGENA, LAHJHLANDCD MIOGCKLPGGA, KNOKFGDBNBL OPICEAAMKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x858D180", Offset = "0x858BB80", VA = "0x18858D180", Slot = "11")]
		public bool Equals(OBEDBECEGGO NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x858D210", Offset = "0x858BC10", VA = "0x18858D210", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x858D350", Offset = "0x858BD50", VA = "0x18858D350")]
		private bool NPLCCEHFMEG(KCOAMLNCGBD NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x858D2D0", Offset = "0x858BCD0", VA = "0x18858D2D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BECGBNPHHLA : OBEDBECEGGO, IEquatable<OBEDBECEGGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct OPJBMEHGECG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public BECGBNPHHLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<MKIOIHPBAPC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8599AD0", Offset = "0x85984D0", VA = "0x188599AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8599D20", Offset = "0x8598720", VA = "0x188599D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly BAMNMDPIDIE BMBODJOOALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FOPNIDOJMAH FAABMNDOOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly KJBCKNKJMLC KKNIHMFPALJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int JEADMECIHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x857E4B0", Offset = "0x857CEB0", VA = "0x18857E4B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LAHJHLANDCD FLMIPHDCLAC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x857E420", Offset = "0x857CE20", VA = "0x18857E420", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JHILFFIDEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x857E0C0", Offset = "0x857CAC0", VA = "0x18857E0C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FOPNIDOJMAH? FPPGEFPDJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x857E550", Offset = "0x857CF50", VA = "0x18857E550", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KJBCKNKJMLC? KNAFPNPMIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x857E350", Offset = "0x857CD50", VA = "0x18857E350", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OBFIADBCAIK IFDGANOFIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC63550", Offset = "0xC61F50", VA = "0x180C63550", Slot = "10")]
			get
			{
				return default(OBFIADBCAIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBD70", Offset = "0x1FCA770", VA = "0x181FCBD70")]
		public BECGBNPHHLA(BAMNMDPIDIE CIFPMGHKBEJ, FOPNIDOJMAH KDHPIELOGKB, KJBCKNKJMLC JLLCEGHIPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x857E110", Offset = "0x857CB10", VA = "0x18857E110", Slot = "9")]
		[AsyncStateMachine(typeof(OPJBMEHGECG))]
		public Task<MKIOIHPBAPC> BPONJBCGIMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x857E200", Offset = "0x857CC00", VA = "0x18857E200", Slot = "11")]
		public bool Equals(OBEDBECEGGO NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x857E2A0", Offset = "0x857CCA0", VA = "0x18857E2A0", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x857E4F0", Offset = "0x857CEF0", VA = "0x18857E4F0")]
		private bool NPLCCEHFMEG(BECGBNPHHLA NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x857E3A0", Offset = "0x857CDA0", VA = "0x18857E3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class PBIGLCGAIOA : OBEDBECEGGO, IEquatable<OBEDBECEGGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct EDNEKBAIMDE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<MKIOIHPBAPC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8580C70", Offset = "0x857F670", VA = "0x188580C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8580ED0", Offset = "0x857F8D0", VA = "0x188580ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly LAHJHLANDCD EOKAIOLDJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly FOPNIDOJMAH FAABMNDOOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly KJBCKNKJMLC KKNIHMFPALJ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int JEADMECIHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x859A030", Offset = "0x8598A30", VA = "0x18859A030", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LAHJHLANDCD FLMIPHDCLAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JHILFFIDEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FOPNIDOJMAH? FPPGEFPDJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x859A130", Offset = "0x8598B30", VA = "0x18859A130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KJBCKNKJMLC? KNAFPNPMIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8599F50", Offset = "0x8598950", VA = "0x188599F50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OBFIADBCAIK IFDGANOFIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "10")]
			get
			{
				return default(OBFIADBCAIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBD70", Offset = "0x1FCA770", VA = "0x181FCBD70")]
		public PBIGLCGAIOA(LAHJHLANDCD MIOGCKLPGGA, FOPNIDOJMAH KDHPIELOGKB, KJBCKNKJMLC JLLCEGHIPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8599D90", Offset = "0x8598790", VA = "0x188599D90", Slot = "9")]
		[AsyncStateMachine(typeof(EDNEKBAIMDE))]
		public Task<MKIOIHPBAPC> BPONJBCGIMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8599E60", Offset = "0x8598860", VA = "0x188599E60", Slot = "11")]
		public bool Equals(OBEDBECEGGO NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8599ED0", Offset = "0x85988D0", VA = "0x188599ED0", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8599FA0", Offset = "0x85989A0", VA = "0x188599FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x859A050", Offset = "0x8598A50", VA = "0x18859A050")]
		private bool NPLCCEHFMEG(PBIGLCGAIOA NDNHELJMDCG)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MJLJKELFHEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<OBEDBECEGGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BGGFHNOCGLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<KNOKFGDBNBL> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<KNOKFGDBNBL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LAHJHLANDCD account, KNOKFGDBNBL roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8592940", Offset = "0x8591340", VA = "0x188592940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85937D0", Offset = "0x85921D0", VA = "0x1885937D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FIBBKMNLPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LAHJHLANDCD account, KNOKFGDBNBL roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<KNOKFGDBNBL> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BGGFHNOCGLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<LAHJHLANDCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8581900", Offset = "0x8580300", VA = "0x188581900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85822D0", Offset = "0x8580CD0", VA = "0x1885822D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PDKPEBPEKLO EMIMEKCJINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GIAOLNEPFEN EFIKIBICAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JOMGIDANJLJ APOFFDNMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly NLGJDJPALEH<(long, long), IReadOnlyList<KNOKFGDBNBL>> BLCPGJHCAGP;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x857E9A0", Offset = "0x857D3A0", VA = "0x18857E9A0")]
	[UnityEngine.Scripting.Preserve]
	public BGGFHNOCGLI([CNHMBDDCGKB(null)] GIAOLNEPFEN LADJHPJJLPM, [CNHMBDDCGKB(null)] JOMGIDANJLJ FHMFHDLBBPC, [CNHMBDDCGKB(null)] PDKPEBPEKLO NCPKIBLNAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x857E850", Offset = "0x857D250", VA = "0x18857E850")]
	[AsyncStateMachine(typeof(MJLJKELFHEG))]
	public Task<IList<OBEDBECEGGO>> PJOLOANGCJP(long FHOIPEIAACP, long HDLFBPMKPAB, bool CHFNOPLKJMM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x857E5A0", Offset = "0x857CFA0", VA = "0x18857E5A0")]
	private bool HNFEFJALCHI(DateTime? JHKCLDKEKOB, long FHOIPEIAACP, long HDLFBPMKPAB, [Out] BAMNMDPIDIE HGDFIMDKHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x857E740", Offset = "0x857D140", VA = "0x18857E740")]
	[AsyncStateMachine(typeof(FIBBKMNLPIM))]
	private Task<IReadOnlyList<(int, LAHJHLANDCD, KNOKFGDBNBL)>> NBFAMAENILA(IReadOnlyList<KNOKFGDBNBL> MGMILOJLMDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JOMGIDANJLJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BAMNMDPIDIE> PNBAOLEGMFC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OGGDPFKMDDG(long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG, GCBBLAMCFIM JABFDEBGCIN);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PIMCJKPJPJK(long FHOIPEIAACP, long HDLFBPMKPAB, [Out] BAMNMDPIDIE HGDFIMDKHKE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CCBFCBLEIKJ(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, [Out] BAMNMDPIDIE HGDFIMDKHKE);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIIPHBLHKPL(long FHOIPEIAACP, long HDLFBPMKPAB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface CLEBFCONPFG : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool FHHGMDJMLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task DGODNJKNIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGGCMONJFME(Task HAAEKADIBMM, string JCLDEGBMKPH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface ODPAPHIFHIO : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MKIOIHPBAPC> FNGIAEPNMDG(BAMNMDPIDIE HGDFIMDKHKE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IMPKJALLONA(CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface KBAKMBAAPLC : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OIOAOOLIIFE MONAHCODJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCPEJMIGJFB();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIDKDNBOPHP();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PBPILMLJLCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface NJLIBBEKNGN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan LIJKILNJGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan LLOBECNDHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LFAKIGJGMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan CMEFKKFOLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EHGHKAJNFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KFLJOBEIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PFMNHPJKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int EFAMICDJOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KOJAPBGPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OHHKHLDCLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool KOBOFFOHONF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LPIINMHFANG
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum HPJOEAHNKPG
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct NPPCBBFHGKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long BHJHEKIDPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long IIHAMPMIGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly LPIINMHFANG HHCAOFMCNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception MOPJHNMCCOK;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8598C90", Offset = "0x8597690", VA = "0x188598C90")]
	public NPPCBBFHGKB(long BHJHEKIDPID, long IIHAMPMIGID, LPIINMHFANG HHCAOFMCNLG, [CanBeNull] Exception MOPJHNMCCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8598C40", Offset = "0x8597640", VA = "0x188598C40")]
	public static NPPCBBFHGKB ALHLPHFCPPN(AKIBJNGPBHA KDNPHNDELGB, LPIINMHFANG HHCAOFMCNLG, [Optional] Exception MOPJHNMCCOK)
	{
		return default(NPPCBBFHGKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void NHALNBDKBHG(NPPCBBFHGKB MAHHBHOMIJN);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface IOLIOOGCIMH : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NHALNBDKBHG KONMKGPAFPO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NHALNBDKBHG AFDDABFLAHK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NHALNBDKBHG KGDOKIJGKBK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<HPJOEAHNKPG, bool> MGHJOPAPNML;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MGAJCJIFLPC(NPPCBBFHGKB MAHHBHOMIJN);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICKHAMDMHPN(NPPCBBFHGKB MAHHBHOMIJN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KHFKFNAEDBB(NPPCBBFHGKB MAHHBHOMIJN);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LAMEKNEBHII(HPJOEAHNKPG OFENPOIFLNA, bool CACGHLMLDCI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface PDIGPGJLKNI : PBPILMLJLCM, IDisposable, LHBDCPKFGEO
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MNEBJELMDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFDMMMPBHEL();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface LLJMALKPDCO : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus KOJOBLAJMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EANNGIPCDCO(AKIBJNGPBHA JAOKMPOOJCM, EFLDNNPDEGB MBJMPJODHJI, CancellationToken IFGGPDNONLM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class LHNCFEDLNNA
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85903E0", Offset = "0x858EDE0", VA = "0x1885903E0")]
	public static bool JMLKKJEMKHE(this LLJMALKPDCO JNKIODNFKGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task OBCGFPOCMIK(CancellationToken BECBHDDLOHA, int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LHGEHMBEHHE : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLKLACLKDJD(OBCGFPOCMIK DMEOEPFEMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HKFGPGHMLEK : POJDIKBGDHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken IIIFPBIJKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MHGNCMHMEKD JDALHNAFDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ICKNPKBJODA EAGNIMPCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IMKJJHDGMOH PFOOKKKFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	LFINHENNLKA CNELLNIJCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PEPJGPLIJNM AHLADAEHCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OBLLMGJFLEG INNALHILPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EGNOIGEDNKF NJAMNBNJPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CLEBFCONPFG IBLLBKINKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	ODPAPHIFHIO NDMMKEMEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IOLIOOGCIMH MOFIOOKNECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PDIGPGJLKNI PAOGIBLPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LLJMALKPDCO NNCNJFDKPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LHGEHMBEHHE AKAJGDPHJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LDFMNPJEPAK PAHBBBFOAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JPBJLLNELNA AHFMODBLFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	POOAGLCFPBF CGDCIICNNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AAPBPBAFHNC HFECLNEFHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IBDMDBGAGNJ GJOKFCPJNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BAGBLNJGMFA BIBDHBPJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GGJJCGFDIHD NPPAEEJAPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HIOIBLBFHFA CJEICLLJHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	KIBDGJPELKK OILCJMHPGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GEEADGMGHGF HLDBKFKAKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KBAKMBAAPLC PCLJOECHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NJLIBBEKNGN HGILPDPFLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FKLEENCAODN NHHJNILKCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JOMGIDANJLJ CBHLHBPABHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	ECDKCDAMMIP IDNKMEHHCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	LMPNAOLEGDD HAOHPNDGLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	LGOEPKDHDBJ AFDJENCHEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	EANLFKMKDNP FKJJEBBCODL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool JLHGKAJDKIL
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
	void GPKNMMPPCGA(EFLDNNPDEGB IMKEAPLGLEA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface LDFMNPJEPAK : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEODKHABLII PBDMKLNODMP(Guid CFNOFGNKICA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DAAFLACHELB(Guid CFNOFGNKICA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANCAIOEGCMP(Guid CFNOFGNKICA, Task DJBIHPNKNOB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHIOHEEACHI(Guid CFNOFGNKICA, MKIOIHPBAPC KPHNHMJHAKG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(MKIOIHPBAPC, Task)> FAKCCODIELP(Guid CFNOFGNKICA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface OALBFPOKLLG : PBPILMLJLCM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface JPBJLLNELNA : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFPLIFLACKN(OBIDIGOJIIL IJOJGNJMCGP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAPPCNLMBDF(OBIDIGOJIIL IJOJGNJMCGP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KCGEDCCFACD> IPKOCAEJNPA(CancellationToken PFAKIDAFOHL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface POOAGLCFPBF : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEODKHABLII BAEJLNEPDAE(OBIDIGOJIIL PDPODIPFEJC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFCOEOPDIGI(Guid CFNOFGNKICA, Task DJBIHPNKNOB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface AAPBPBAFHNC : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MKIOIHPBAPC> HFECLNEFHNG(OBIDIGOJIIL AGAELLMOCGI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface IBDMDBGAGNJ : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKKKLGNDOCB> NMOIKMDFKCA(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, AKIBJNGPBHA JAOKMPOOJCM, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface GGJJCGFDIHD : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKIOIHPBAPC HFKINFEGOJO(GBDECDHLMJN BGKOOGGEMEH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CFJKOKNJHNN(string KJHMBICDBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface BAGBLNJGMFA : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBIDIGOJIIL> NHHAIJBJHJL(OBIDIGOJIIL OHOKHLNBDDB, GIPKKFBMGMB NAFHMMBAILG, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OBIDIGOJIIL> GMNKMODPGKJ(CancellationToken JKPNCAGHEDI, GIPKKFBMGMB NAFHMMBAILG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJLOAOIEJAJ DJEDAJHGJIE(CPEALFJADBF FOPLMKGNNJD, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JJLOAOIEJAJ OLENPPDNGLF(CPEALFJADBF FOPLMKGNNJD, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface HIOIBLBFHFA : PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKIOIHPBAPC MKOLLGAJBCD(GBDECDHLMJN BGKOOGGEMEH, KCGEDCCFACD CHMCGCPFKNJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKIOIHPBAPC CCBJGJGNEJC(GBDECDHLMJN DCMMAAEJIEE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DJHFAFFDAKG
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int NPBMPBHACMA = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, GLAHIBCIEJL> AHAMOPADLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action CBPMHJAMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> CDPNBDPKMBJ();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LILKCDKIBDM([Optional] CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LFDOCFHHHEO([Optional] CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KIBDGJPELKK
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAODCAMEAEC(OAPINCBOEGG DDIOMGKBJFF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKLGHBFOCAG(OAPINCBOEGG DDIOMGKBJFF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFFIOEAAEMH(OAPINCBOEGG DDIOMGKBJFF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFHEHOOCKIF(OAPINCBOEGG DDIOMGKBJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OAPINCBOEGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly AKIBJNGPBHA NIFNMDMAKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> HCEOIMHBBLC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JBLIEDANKLD<string> ODDPBLLPJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public OAPINCBOEGG(AKIBJNGPBHA HDBNMLIMHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8598DC0", Offset = "0x85977C0", VA = "0x188598DC0")]
	public OAPINCBOEGG NCDMGHNGELK(string KJNEHANBOBO, string PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8598D30", Offset = "0x8597730", VA = "0x188598D30")]
	public bool HNNLCALGDOD([Out] IEnumerable<KeyValuePair<string, string>> BCCBDCOFABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x73C7CB0", Offset = "0x73C66B0", VA = "0x1873C7CB0")]
	public OAPINCBOEGG BFECGONBJLE(JBLIEDANKLD<string> JNHNJKFGOJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FKLEENCAODN
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LKCNGKMJDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string PGIEFKENABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool HCKIJBHFCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBIJGCLEBLB();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CGHCFDNOEBP PDEKECLOGPI(long LOMEDBPBLPM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NKCECGKOLIK<LKFLNLIEOOH, FKOCDIMDNEB> HLBLLNDCMKH(long LOMEDBPBLPM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NKCECGKOLIK<LKFLNLIEOOH, BGHEHCDAEKD> BEIIPNIJMEN(long LOMEDBPBLPM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NKCECGKOLIK<long, LANBKINAPGH> JKJHNCJHEFI();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<CCIEPLLJIFN>> GOHIPCFCKMB(long LOMEDBPBLPM, IReadOnlyCollection<CCIEPLLJIFN> COIKIMKCKPP, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EGFKIALIKMD(long LOMEDBPBLPM, [Out] bool FCFGGEOONEL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> DHCDMDAFDGI(byte[] OHHJLEDHKKJ, byte[] AFJBMFELNHB, IReadOnlyCollection<Guid> EDOKJLEBIOO, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IAGCFAJDJGB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKKKLGNDOCB JEBOFNEMEAN(long BHJHEKIDPID, long IIHAMPMIGID, string DPKNLEFMODL);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKKKLGNDOCB JEBOFNEMEAN(long BHJHEKIDPID, long IIHAMPMIGID, LKFLNLIEOOH OHHJLEDHKKJ, Guid? DNAKELKDJFC, long OHKJMOJNDCK, bool FDGMGDOMFIP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKKKLGNDOCB JEBOFNEMEAN(LOKCFGIBPOM LNAHBLGNONB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JKKKLGNDOCB JEBOFNEMEAN(PFLGPOLCCPC PHIAJLKAMFE, KNOKFGDBNBL PGOIIKFLMKI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface POJDIKBGDHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool JMLKKJEMKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool IIGKGJFJMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool JLHGKAJDKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	IAGCFAJDJGB GNGJMCCKNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	EFLDNNPDEGB LGACNCIJMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NHALNBDKBHG KONMKGPAFPO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NHALNBDKBHG AFDDABFLAHK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NHALNBDKBHG KGDOKIJGKBK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HPJOEAHNKPG, bool> MGHJOPAPNML;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFDMMMPBHEL();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LNIMGIIGMMO FNPHAABOIEC();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CEMCGKGJENI MFAEPLHKBHC();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task CHJADHDODPL(int DPBNEMHNHCP, DMEFFBPJOFP PBNMCEIBAFO, Func<KIPPLECGJII, KIPPLECGJII> DPPMLEONLPD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<MKIOIHPBAPC> FNGIAEPNMDG(BAMNMDPIDIE CIFPMGHKBEJ);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task IMPKJALLONA(CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LFINHENNLKA
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool DHCGJHAALGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FBNGFKNHLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? IFPKCEFBMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMBAGOGAJEH(Scene EDMGECJGOBB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CKHOEHKFMGK(HHAOPNLAPFK FKKGNBPFCNO, IReadOnlyList<HHAOPNLAPFK> OBJCGOMMPNN, IReadOnlyList<HHAOPNLAPFK> AAPGHKBCCNI, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMGADLPEICH(Guid GJEEKGJKBGO, IReadOnlyList<Guid> EDOKJLEBIOO, MNGONHMLOON PEOBHBDELMC, [Optional] object JKHCBPJEKLO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HICPNMEPCJH(IReadOnlyList<Guid> CEAOHDJPBKP, CancellationToken GNKINEILKKI);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OBMOIIKAPLI CDPNHPOLJKO();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task HCNJJIFHBEL();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAHDGMCOGFB(GameObject MDCCLJKNLLP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task EPPJNIEOKDI();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface EJALGCLEMLF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool JOOMFGJCCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LBBNCAGLECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool FJJONEOMKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool ICIPDFEBBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int KCFPNHILFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool PFAKPFFMJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool MHKAENCEDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int GEEMFHBDNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int CGKLJGNBCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BBLNDNGBOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool MJCFBIAOPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool PHEMKIDAMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float AIDEKHBEGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> OJLPOFLJMIL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHGNCMHMEKD MNPFNCBDLNF(MHGNCMHMEKD HOCODGIAFOF);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIDIDNPBCNI(MHGNCMHMEKD DJGDNAKMFCE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGEAAPMHANG();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task EIIHOJILNAK(JBLIEDANKLD<string>.CKADLEMJOGG FIIOLIEDOCC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACOAMNNCJFD(float NCHGAFOGNCM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCNCNMHCICK(string DCBDCJILPIG);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<OACHJIOLDGM> LPNPBLMMPDA();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable AEPKLKDILCN(object GJIMIGJJJKI, OACHJIOLDGM NGGCDDHMKBK);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<IMPFOMMMKKI> KLOFLNMPEEE();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FKOCDIMDNEB LLIIJCIFLIG(IEnumerable<CEIEJPOFNOJ> FHGEBGHKCAK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HFHMHJCJENA(int PGBNNEFOMAE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task DLDMGMICGJI();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LELKHCEBJMB();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JNJLFOCMABD();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BBOEMHBFNOK(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task MGHLBMHFGBL(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<PAICFMGKIHK> DHDDMCKMOIJ(DateTime CMNGNBDKIEE, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> KJJPOJLCPLN(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BCLKJLKLCMA(string IJOJGNJMCGP = "", float IDDLOIFGNLI = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	AEJBFPJDNNO MIJGJGMNCGJ(NACFJGFGJCK CLGMFHFAPGH, LOECPFNBOHH IPMPKPIBGHH, BGHEHCDAEKD OPKACFNMCHG, IEnumerable<PersistenceView> MCNLGCPADDM, OHBJFKNEAGF MPCAEJFHCJD);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NHMDOKEFCFB(BGHEHCDAEKD OPKACFNMCHG);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HMPKFFGNFBM(CEIEJPOFNOJ IMNAAJEOHCB, [In] AEJBFPJDNNO HEJIOBJPEMA);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task FPJMOBIPLII(BGHEHCDAEKD DJMELIEHAHC, bool ABPMPKLKFJM, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task CGJFKONHIBI(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BLGEHFEFFFA(long FHOIPEIAACP, long IIHAMPMIGID, PFLGPOLCCPC DOMHKNEHBED, KNOKFGDBNBL MDBCAOONPIF, KIPPLECGJII CFHMLKEGBGG, DMEFFBPJOFP? PBNMCEIBAFO, MCOPGAMEPGG? OCEPADJCNLO);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AEBOMJOJFKF(long FHOIPEIAACP, long IIHAMPMIGID, MCOPGAMEPGG? OCEPADJCNLO);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MHHGPBKOKCI(PersistenceView PEACEMAFPCC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void DGIPNFMOPKO(string ANIONBDNONN, AKIBJNGPBHA HDBNMLIMHPI, MNEFCBHAIEP HNADNDMLMAO, [Optional] string? NABIMEGKBNJ, [Optional] string? BPDHGKLNKOA, [Optional] string? CJHKMCKHMNO);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool DGMGNGPMLEM(PersistenceView MMGGIIKGBNM);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PLGBBMAOILI(CEIEJPOFNOJ IMNAAJEOHCB, OGEHLNKGNIL DELIMBDIELN, [Out] EHJPCDGEBBK HEOGJOHOMCO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task OHEHMHELFLD(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void HCBKBIOFIEI();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable FGEAAPJDBDD();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void CIBIDLOCJDE(BGHEHCDAEKD DJMELIEHAHC, OGEHLNKGNIL DELIMBDIELN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> IOJHMNLIIPP(ICKNPKBJODA JEJFACEGMCJ, CancellationToken JKPNCAGHEDI, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void PAAIPOPDMBG(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<LOKCFGIBPOM> EMLKONFCNOB(FIOHEILDDIF OHOKHLNBDDB);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<PFLGPOLCCPC> FFPGOAFLPKF(long FHOIPEIAACP, bool LIFPBHNEBBD, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<CGCLGPHBJCJ> BECMFPOKLJD(long FHOIPEIAACP, long IIHAMPMIGID, long OHKJMOJNDCK, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<KNOKFGDBNBL> IFKGHKGHIOI(long FHOIPEIAACP, long IIHAMPMIGID, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<FIDOJLMNKGC> IGJOHCJHIPN(long FHOIPEIAACP, Guid APPGCPAKCPN, long? HDLFBPMKPAB, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	NKCECGKOLIK<FIDOJLMNKGC, IEnumerable<KFMMELOCOBN>> KONGIIPNEDP();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<CIJBIBHOKLO> DBGJIICDFPB(string DPKNLEFMODL, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<CIJBIBHOKLO> JJEBCJNAKFL(string DPKNLEFMODL, long FHOIPEIAACP, long IIHAMPMIGID, Guid? GJEEKGJKBGO, JKDEDGGKCKI.NOAHHBKMMMD NIAPBNPEIPM, JKDEDGGKCKI.NOAHHBKMMMD AFJBMFELNHB, int DPBNEMHNHCP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OBKGLJFLNFB();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool APLLBKILFBB();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool FEAOOELICKC(IEnumerable<EHJPCDGEBBK> ILEKFCOEDLP);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void DEPIMFPKHFM(List<GameObject> HOFIJGPBLLF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float GOPLPKEJKBF();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> BGCIJGNJPBJ(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> LIOOMJEMBAO(string HLFANMELOFL, LoadSceneMode ANNMPLJLEKM, bool HGCDIEMGEPF, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void OFKJFMBKGEM(bool KALBLPGLPEO);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void CNPPIMLPDEJ();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void LLALNMGDNHL();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BCEEAGOFEEK(bool IFGINNOKBDM);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<JKDEDGGKCKI.NOAHHBKMMMD> JHLLFFIAIGF(byte[] HPGIDELCODH, JKDEDGGKCKI.DEEEANAPNML DOHEKOGIKMF, ALINJHAIMJM HMKMKJJFADB, [Optional] IReadOnlyCollection<string>? CAMELILGKFM, [Optional] string? MMDNHHNENCL);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void JGCJAPIDIBC(AKIBJNGPBHA NJHMHPLAPDF);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task DABIMMAMCPL(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task EJILOIMPCBA(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task AIFNPGHAFMN(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task MECHPGANGMI(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable GDIJDMOHIAG();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	AECCBCEBOOE KBEPNCJGKIC();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task ODPELLKKGJN(CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AECCBCEBOOE
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OOIFHMOAKBO(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IHCCOJFHCFE(CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct AEJBFPJDNNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> MFDMJMMFHFL;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum PAICFMGKIHK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NACFJGFGJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? PJGFMPKJDCB;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JOFBKCGIJED
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	AKIBJNGPBHA IILAHPGEJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	PFLGPOLCCPC LPDLHGOEIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	BBAIIGBMJIM NKIGCIECBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool EHOJNJNGKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OBJOAPMPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int JOMJOJFJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action LMIIIPJAOCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> DLKNHGHBEHM;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JHIBPFPOIBG();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PHGBJKEPAAK> GINLDPDHPOC(long LOMEDBPBLPM, [Optional] CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BOLFHMOGPFO> OGJLGAOBMAI(AKIBJNGPBHA HDBNMLIMHPI, [Optional] EFLDNNPDEGB MBJMPJODHJI);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<BOLFHMOGPFO> GPKMJLPCEJP();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HCIJKPHNFNA();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(AKIBJNGPBHA, EFLDNNPDEGB) FEHKLIIEAGH();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MMPJCCHHOBG KCDIEBIIPJP();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NFDCPFNMFJB(long LOMEDBPBLPM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ECIKICEIEPO(AKIBJNGPBHA HDBNMLIMHPI, Matchmaking.BIEOCDGGFMF MGJNMKLFKCJ, (int Major, int? Minor)? IPOOJEEDJGK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GEEADGMGHGF
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNCPKHFCPMD([Out] IEnumerable<int> MAFJMEEOAIJ);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFNEKBAFBNJ(EPPGEGDDHJJ BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJBJOMNPOEA(EPPGEGDDHJJ BECBHDDLOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JHJKCGHHAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MEHJJKKIBPK(MKIOIHPBAPC CNFJLDGBMJE);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface IGLHJOALLHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COAHAPNNFCP(GAOJGDJBHOO.HCEFACDICAD LCFCCHFFBHA);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBDECIMFNEE(GAOJGDJBHOO.HCEFACDICAD LCFCCHFFBHA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface PEPJGPLIJNM : IGLHJOALLHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKIOIHPBAPC OAFEFKBCPLE(GBDECDHLMJN DCMMAAEJIEE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OBLLMGJFLEG : IGLHJOALLHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKIOIHPBAPC HFKINFEGOJO(GBDECDHLMJN IKJHHAOIKGK);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CGHCFDNOEBP
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> ONADJPOFMGC(Guid? GJEEKGJKBGO, IReadOnlyCollection<CCIEPLLJIFN> NENPIFCAJKP, IReadOnlyCollection<CCIEPLLJIFN> ODGALKHABCJ, JBFKPDFMNMD BFGFJFGCICH, long? FHOIPEIAACP, long? IIHAMPMIGID, FKKEGKBKICJ.PAADLMLBGCD INPBDLCMNLK, CancellationToken JKPNCAGHEDI, bool DLBNKPFGOBL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class NFIEJJOKOOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public HHAOPNLAPFK NDFBKDMLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<HHAOPNLAPFK> LDLKIEPGBII
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<HHAOPNLAPFK> OMMCCCLAEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xCC55F0", Offset = "0xCC3FF0", VA = "0x180CC55F0")]
	public NFIEJJOKOOJ(HHAOPNLAPFK JPDFPOJKGLO, IReadOnlyList<HHAOPNLAPFK> AAIJBABMLKD, IReadOnlyList<HHAOPNLAPFK> GKKEAIKGEHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NKCECGKOLIK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KAFLOHEKGBO<GODECPCJOOD<TData>, GJIFJLKDAGC>> ECKICBOHFNJ(TGetDataArg EFPDHJCEEGP, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class PDGPEIODFFC : HKFGPGHMLEK, POJDIKBGDHI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NDNAGFOLDNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PDGPEIODFFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BAMNMDPIDIE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<MKIOIHPBAPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8594CF0", Offset = "0x85936F0", VA = "0x188594CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8594F70", Offset = "0x8593970", VA = "0x188594F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KLDMFEJFKAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public PDGPEIODFFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x858DCE0", Offset = "0x858C6E0", VA = "0x18858DCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x858DF10", Offset = "0x858C910", VA = "0x18858DF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class MHCPJFLKPGP : IEnumerable<PBPILMLJLCM>, IEnumerable, IEnumerator<PBPILMLJLCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private PBPILMLJLCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PDGPEIODFFC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private PBPILMLJLCM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public MHCPJFLKPGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8592490", Offset = "0x8590E90", VA = "0x188592490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85928F0", Offset = "0x85912F0", VA = "0x1885928F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8592840", Offset = "0x8591240", VA = "0x188592840", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PBPILMLJLCM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8592840", Offset = "0x8591240", VA = "0x188592840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource EIEPDIBNNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MHGNCMHMEKD DJGDNAKMFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private KEFPAACMFMI KPHLMKJMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool HOMJAIINHIA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ICKNPKBJODA EAGNIMPCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IMKJJHDGMOH PFOOKKKFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LFINHENNLKA CNELLNIJCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public PEPJGPLIJNM AHLADAEHCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA17C40", Offset = "0xA16640", VA = "0x180A17C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OBLLMGJFLEG INNALHILPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA09160", Offset = "0xA07B60", VA = "0x180A09160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IAGCFAJDJGB GNGJMCCKNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA09280", Offset = "0xA07C80", VA = "0x180A09280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EGNOIGEDNKF NJAMNBNJPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA09300", Offset = "0xA07D00", VA = "0x180A09300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public CLEBFCONPFG IBLLBKINKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA6B540", Offset = "0xA69F40", VA = "0x180A6B540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public ODPAPHIFHIO NDMMKEMEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA092A0", Offset = "0xA07CA0", VA = "0x180A092A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IOLIOOGCIMH MOFIOOKNECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA87000", Offset = "0xA85A00", VA = "0x180A87000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PDIGPGJLKNI PAOGIBLPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3C0", Offset = "0xA0BDC0", VA = "0x180A0D3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public LLJMALKPDCO NNCNJFDKPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA871F0", Offset = "0xA85BF0", VA = "0x180A871F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LHGEHMBEHHE AKAJGDPHJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAB9040", Offset = "0xAB7A40", VA = "0x180AB9040", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAB9020", Offset = "0xAB7A20", VA = "0x180AB9020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public LDFMNPJEPAK PAHBBBFOAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA86FC0", Offset = "0xA859C0", VA = "0x180A86FC0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAB9000", Offset = "0xAB7A00", VA = "0x180AB9000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public OALBFPOKLLG FMKHPPIFDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA86FD0", Offset = "0xA859D0", VA = "0x180A86FD0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA86DE0", Offset = "0xA857E0", VA = "0x180A86DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JPBJLLNELNA AHFMODBLFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA744D0", Offset = "0xA72ED0", VA = "0x180A744D0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA74170", Offset = "0xA72B70", VA = "0x180A74170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public POOAGLCFPBF CGDCIICNNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA0D440", Offset = "0xA0BE40", VA = "0x180A0D440", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA0D370", Offset = "0xA0BD70", VA = "0x180A0D370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public AAPBPBAFHNC HFECLNEFHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA744E0", Offset = "0xA72EE0", VA = "0x180A744E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA73C50", Offset = "0xA72650", VA = "0x180A73C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IBDMDBGAGNJ GJOKFCPJNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA7A570", Offset = "0xA78F70", VA = "0x180A7A570", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA7CC80", Offset = "0xA7B680", VA = "0x180A7CC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BAGBLNJGMFA BIBDHBPJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA7A580", Offset = "0xA78F80", VA = "0x180A7A580", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB2C460", Offset = "0xB2AE60", VA = "0x180B2C460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GGJJCGFDIHD NPPAEEJAPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA7F280", Offset = "0xA7DC80", VA = "0x180A7F280", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE20", Offset = "0xA79820", VA = "0x180A7AE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public HIOIBLBFHFA CJEICLLJHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEB30", Offset = "0xAAD530", VA = "0x180AAEB30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8C90", Offset = "0xAA7690", VA = "0x180AA8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KIBDGJPELKK OILCJMHPGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA7F070", Offset = "0xA7DA70", VA = "0x180A7F070", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE40", Offset = "0xA79840", VA = "0x180A7AE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GEEADGMGHGF HLDBKFKAKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE6F0", Offset = "0xAAD0F0", VA = "0x180AAE6F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEB80", Offset = "0xAAD580", VA = "0x180AAEB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KBAKMBAAPLC PCLJOECHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA7F220", Offset = "0xA7DC20", VA = "0x180A7F220", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA7B5C0", Offset = "0xA79FC0", VA = "0x180A7B5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NJLIBBEKNGN HGILPDPFLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB36240", Offset = "0xB34C40", VA = "0x180B36240", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB39D70", Offset = "0xB38770", VA = "0x180B39D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public FKLEENCAODN NHHJNILKCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA30", Offset = "0xAAD430", VA = "0x180AAEA30", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA8F30", Offset = "0xAA7930", VA = "0x180AA8F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JOMGIDANJLJ CBHLHBPABHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE6E0", Offset = "0xAAD0E0", VA = "0x180AAE6E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public ECDKCDAMMIP IDNKMEHHCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xB2BA50", Offset = "0xB2A450", VA = "0x180B2BA50", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public LMPNAOLEGDD HAOHPNDGLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB2C1A0", Offset = "0xB2ABA0", VA = "0x180B2C1A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public LGOEPKDHDBJ AFDJENCHEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xB302E0", Offset = "0xB2ECE0", VA = "0x180B302E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EANLFKMKDNP FKJJEBBCODL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xB48D10", Offset = "0xB47710", VA = "0x180B48D10", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public EFLDNNPDEGB LGACNCIJMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB2C5B0", Offset = "0xB2AFB0", VA = "0x180B2C5B0", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCB64B0", Offset = "0xCB4EB0", VA = "0x180CB64B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool PGEMKEOGNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x859ABF0", Offset = "0x85995F0", VA = "0x18859ABF0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool MNMINEMEMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x859AEF0", Offset = "0x85998F0", VA = "0x18859AEF0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool EEENKABHGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D784F0", Offset = "0x1D76EF0", VA = "0x181D784F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken ANJKIDINPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x859AF70", Offset = "0x8599970", VA = "0x18859AF70", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private MHGNCMHMEKD BBGJFCAFFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool BJMJAENDIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D784F0", Offset = "0x1D76EF0", VA = "0x181D784F0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D72890", Offset = "0x1D71290", VA = "0x181D72890", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event NHALNBDKBHG CIOKDNBNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x859A250", Offset = "0x8598C50", VA = "0x18859A250", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x859AA80", Offset = "0x8599480", VA = "0x18859AA80", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event NHALNBDKBHG DAJFAHKJKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x859AB30", Offset = "0x8599530", VA = "0x18859AB30", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x859AB90", Offset = "0x8599590", VA = "0x18859AB90", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event NHALNBDKBHG BFCJCDFJJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x859AE00", Offset = "0x8599800", VA = "0x18859AE00", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x859ADA0", Offset = "0x85997A0", VA = "0x18859ADA0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<HPJOEAHNKPG, bool> FFAFJIGMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x859ACB0", Offset = "0x85996B0", VA = "0x18859ACB0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x859A1F0", Offset = "0x8598BF0", VA = "0x18859A1F0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xCB64B0", Offset = "0xCB4EB0", VA = "0x180CB64B0", Slot = "39")]
	public void GPKNMMPPCGA(EFLDNNPDEGB IMKEAPLGLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x859B0A0", Offset = "0x8599AA0", VA = "0x18859B0A0")]
	[UnityEngine.Scripting.Preserve]
	internal PDGPEIODFFC([CNHMBDDCGKB(null)] MHGNCMHMEKD DJGDNAKMFCE, [CNHMBDDCGKB(null)] ICKNPKBJODA JEJFACEGMCJ, [CNHMBDDCGKB(null)] IMKJJHDGMOH IKHNLLNHCPF, [CNHMBDDCGKB(null)] EJALGCLEMLF FLJMNPJIKOM, [CNHMBDDCGKB(null)] LFINHENNLKA GIONIMPDACP, [CNHMBDDCGKB(null)] PEPJGPLIJNM FCGCKMEDFKP, [CNHMBDDCGKB(null)] OBLLMGJFLEG KNNGAINLICA, [CNHMBDDCGKB(null)] EGNOIGEDNKF DOGCKMIKKOD, [CNHMBDDCGKB(null)] CLEBFCONPFG GAGBBFPHMPM, [CNHMBDDCGKB(null)] ODPAPHIFHIO PGEPCJKGGDN, [CNHMBDDCGKB(null)] IOLIOOGCIMH GKEBBNCFKMF, [CNHMBDDCGKB(null)] PDIGPGJLKNI HIFPDJJHCAI, [CNHMBDDCGKB(null)] LLJMALKPDCO JNKIODNFKGF, [CNHMBDDCGKB(null)] LHGEHMBEHHE BJMKCJPJHDP, [CNHMBDDCGKB(null)] LDFMNPJEPAK DHEFFMPMCGH, [CNHMBDDCGKB(null)] OALBFPOKLLG JKLBGJLBIBM, [CNHMBDDCGKB(null)] JPBJLLNELNA LEEMLFCABNH, [CNHMBDDCGKB(null)] POOAGLCFPBF NMLIHFBGFLC, [CNHMBDDCGKB(null)] AAPBPBAFHNC OMEGAOJLCEA, [CNHMBDDCGKB(null)] IBDMDBGAGNJ FNBAKEJHDPB, [CNHMBDDCGKB(null)] GGJJCGFDIHD OPCKOCGHGGE, [CNHMBDDCGKB(null)] BAGBLNJGMFA EMNEDFGECOP, [CNHMBDDCGKB(null)] HIOIBLBFHFA HIDLGKOCDCF, [CNHMBDDCGKB(null)] KIBDGJPELKK MDOGGCJOJCM, [CNHMBDDCGKB(null)] GEEADGMGHGF CDNDAKJCPHG, [CNHMBDDCGKB(null)] NJLIBBEKNGN DHADAJLMNNE, [CNHMBDDCGKB(null)] FKLEENCAODN KACGHKPFJAB, [CNHMBDDCGKB(null)] JOMGIDANJLJ FPBECJGODHJ, [CNHMBDDCGKB(null)] ECDKCDAMMIP CBDBIJBBDNF, [CNHMBDDCGKB(null)] LMPNAOLEGDD HOEJKEDGJHM, [CNHMBDDCGKB(null)] LGOEPKDHDBJ DAMCDMHKDKD, [CNHMBDDCGKB(null)] EANLFKMKDNP GADHCLBNLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x859A5C0", Offset = "0x8598FC0", VA = "0x18859A5C0")]
	private void DBILOAODCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x859A670", Offset = "0x8599070", VA = "0x18859A670", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x859AAE0", Offset = "0x85994E0", VA = "0x18859AAE0", Slot = "51")]
	private void GAFGGGMMOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x859AE60", Offset = "0x8599860", VA = "0x18859AE60", Slot = "52")]
	private LNIMGIIGMMO MDDNDIJFKGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x859AD10", Offset = "0x8599710", VA = "0x18859AD10", Slot = "53")]
	private CEMCGKGJENI JELCAGMMBEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x859A2B0", Offset = "0x8598CB0", VA = "0x18859A2B0", Slot = "55")]
	public Task CHJADHDODPL(int DPBNEMHNHCP, DMEFFBPJOFP PBNMCEIBAFO, Func<KIPPLECGJII, KIPPLECGJII> DPPMLEONLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x859A800", Offset = "0x8599200", VA = "0x18859A800")]
	private MPDGGMIPCBP EBFOILCOPAO(int DPBNEMHNHCP, DMEFFBPJOFP PBNMCEIBAFO, Func<KIPPLECGJII, KIPPLECGJII> DPPMLEONLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x859AF90", Offset = "0x8599990", VA = "0x18859AF90", Slot = "56")]
	[AsyncStateMachine(typeof(NDNAGFOLDNE))]
	private Task<MKIOIHPBAPC> PNOJFIMCGAD(BAMNMDPIDIE HGDFIMDKHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x859A910", Offset = "0x8599310", VA = "0x18859A910", Slot = "57")]
	[AsyncStateMachine(typeof(KLDMFEJFKAA))]
	private Task EPBLJGGKJJB(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x859AA00", Offset = "0x8599400", VA = "0x18859AA00")]
	[IteratorStateMachine(typeof(MHCPJFLKPGP))]
	private IEnumerable<PBPILMLJLCM> FILLHMJHGCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x859AC50", Offset = "0x8599650", VA = "0x18859AC50")]
	[CompilerGenerated]
	private void IBLNLHGGCKF(PBPILMLJLCM FDMBFEDKLFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class FNFJPKFOFOP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x193CB40", Offset = "0x193B540", VA = "0x18193CB40")]
	public FNFJPKFOFOP(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class BBOHOJAKHKH : GKBHAPPJEJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NBGAIKKHNNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<GKBHAPPJEJE.GHFHOEMFPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<LHBDCPKFGEO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public BBOHOJAKHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8593840", Offset = "0x8592240", VA = "0x188593840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8593B40", Offset = "0x8592540", VA = "0x188593B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string MEDPEIIKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x857DDB0", Offset = "0x857C7B0", VA = "0x18857DDB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public BBOHOJAKHKH(HKFGPGHMLEK DLDEJAGLCHP, EJALGCLEMLF FLJMNPJIKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x857DDE0", Offset = "0x857C7E0", VA = "0x18857DDE0", Slot = "5")]
	[AsyncStateMachine(typeof(NBGAIKKHNNF))]
	public Task<GKBHAPPJEJE.GHFHOEMFPLO> GONBNMNMNDL(HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class BKHHJHCOPGO : IMBIDJKLKCJ, GKBHAPPJEJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct ILFOGDDLGOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<GKBHAPPJEJE.GHFHOEMFPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BKHHJHCOPGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HashSet<LHBDCPKFGEO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private AKIBJNGPBHA <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<GKBHAPPJEJE.GHFHOEMFPLO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x858B810", Offset = "0x858A210", VA = "0x18858B810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x858C170", Offset = "0x858AB70", VA = "0x18858C170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string MEDPEIIKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x857EAD0", Offset = "0x857D4D0", VA = "0x18857EAD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public BKHHJHCOPGO(HKFGPGHMLEK DLDEJAGLCHP, EJALGCLEMLF FLJMNPJIKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x857EB00", Offset = "0x857D500", VA = "0x18857EB00", Slot = "5")]
	[AsyncStateMachine(typeof(ILFOGDDLGOA))]
	public Task<GKBHAPPJEJE.GHFHOEMFPLO> GONBNMNMNDL(HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class KIKEIHCMDHL : IMBIDJKLKCJ, GKBHAPPJEJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct LKGENFOMHJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<GKBHAPPJEJE.GHFHOEMFPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KIKEIHCMDHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HashSet<LHBDCPKFGEO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<BOLFHMOGPFO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<GKBHAPPJEJE.GHFHOEMFPLO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8590430", Offset = "0x858EE30", VA = "0x188590430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8590E20", Offset = "0x858F820", VA = "0x188590E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string MEDPEIIKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x858DAE0", Offset = "0x858C4E0", VA = "0x18858DAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public KIKEIHCMDHL(HKFGPGHMLEK DLDEJAGLCHP, EJALGCLEMLF FLJMNPJIKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x858DB10", Offset = "0x858C510", VA = "0x18858DB10", Slot = "5")]
	[AsyncStateMachine(typeof(LKGENFOMHJL))]
	public Task<GKBHAPPJEJE.GHFHOEMFPLO> GONBNMNMNDL(HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class NODCPACGLBE : IMBIDJKLKCJ, GKBHAPPJEJE
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MGFANMGDNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BOLFHMOGPFO matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MGFANMGDNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8592410", Offset = "0x8590E10", VA = "0x188592410")]
		internal object LBJDHLEKCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8592350", Offset = "0x8590D50", VA = "0x188592350")]
		internal object JMJLCMFOIKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct IHCLLJCNHFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder<GKBHAPPJEJE.GHFHOEMFPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NODCPACGLBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HashSet<LHBDCPKFGEO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private MGFANMGDNOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<BOLFHMOGPFO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<GKBHAPPJEJE.GHFHOEMFPLO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x858A800", Offset = "0x8589200", VA = "0x18858A800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x858B420", Offset = "0x8589E20", VA = "0x18858B420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string MEDPEIIKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8598A40", Offset = "0x8597440", VA = "0x188598A40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public NODCPACGLBE(HKFGPGHMLEK DLDEJAGLCHP, EJALGCLEMLF FLJMNPJIKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8598A70", Offset = "0x8597470", VA = "0x188598A70", Slot = "5")]
	[AsyncStateMachine(typeof(IHCLLJCNHFI))]
	public Task<GKBHAPPJEJE.GHFHOEMFPLO> GONBNMNMNDL(HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class IMBIDJKLKCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct OHGBADECPFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public COJJKFBGGKB log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HashSet<LHBDCPKFGEO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public IMBIDJKLKCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private List<LHBDCPKFGEO.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8598F80", Offset = "0x8597980", VA = "0x188598F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x85994A0", Offset = "0x8597EA0", VA = "0x1885994A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	protected readonly HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x858C310", Offset = "0x858AD10", VA = "0x18858C310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public IMBIDJKLKCJ(HKFGPGHMLEK DLDEJAGLCHP, EJALGCLEMLF FLJMNPJIKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x858C1E0", Offset = "0x858ABE0", VA = "0x18858C1E0")]
	[AsyncStateMachine(typeof(OHGBADECPFE))]
	protected Task KBMBNPHFGKA(COJJKFBGGKB PMPMPCJHKKF, HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class HIIJAAALDMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct IFOHDFPHPJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder<GKBHAPPJEJE.GHFHOEMFPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EJALGCLEMLF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8589560", Offset = "0x8587F60", VA = "0x188589560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x85898E0", Offset = "0x85882E0", VA = "0x1885898E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HMAHILFIPLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public HKFGPGHMLEK roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HMAHILFIPLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8589330", Offset = "0x8587D30", VA = "0x188589330")]
		internal object PNKMOHHECMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly float MPLHAJDPELN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal static readonly HashSet<LHBDCPKFGEO.Reason> HCDDHGMBKLA;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8589100", Offset = "0x8587B00", VA = "0x188589100")]
	[AsyncStateMachine(typeof(IFOHDFPHPJN))]
	internal static Task<GKBHAPPJEJE.GHFHOEMFPLO> LOOOHCANJGJ(EJALGCLEMLF FLJMNPJIKOM, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8588F80", Offset = "0x8587980", VA = "0x188588F80")]
	internal static void DOFIOKDBPLL(HKFGPGHMLEK DLDEJAGLCHP, COJJKFBGGKB PMPMPCJHKKF, string ANIONBDNONN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface GKBHAPPJEJE
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct GHFHOEMFPLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public bool CACGHLMLDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LHBDCPKFGEO.Reason CHGJGNFMEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Enum? CJHKMCKHMNO;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8588950", Offset = "0x8587350", VA = "0x188588950")]
		public static GHFHOEMFPLO PLABGECLEBM()
		{
			return default(GHFHOEMFPLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8588920", Offset = "0x8587320", VA = "0x188588920")]
		public static GHFHOEMFPLO MNBMHKFANJK(LHBDCPKFGEO.Reason CHGJGNFMEJJ, [Optional] Enum? CJHKMCKHMNO)
		{
			return default(GHFHOEMFPLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string DANAGCNNCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GHFHOEMFPLO> GONBNMNMNDL(HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct DMPOKGCCDJN
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HOCOJFHFBLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public HKFGPGHMLEK manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HOCOJFHFBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8589510", Offset = "0x8587F10", VA = "0x188589510")]
		internal Task LFLDPJBBNBG(CancellationToken cancellationToken, int roomTotalVersion, IIOJHPILAFO localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct LNEDLGHIMJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public DMPOKGCCDJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private BAMNMDPIDIE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<PAICFMGKIHK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<MKIOIHPBAPC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8590E90", Offset = "0x858F890", VA = "0x188590E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8591420", Offset = "0x858FE20", VA = "0x188591420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct IIODDNNMPDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public DMPOKGCCDJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x858B490", Offset = "0x8589E90", VA = "0x18858B490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x858B7B0", Offset = "0x858A1B0", VA = "0x18858B7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly CancellationToken JKPNCAGHEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly HKFGPGHMLEK BPDOIFAEGPF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private ICKNPKBJODA EAGNIMPCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8580530", Offset = "0x857EF30", VA = "0x188580530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8580BA0", Offset = "0x857F5A0", VA = "0x188580BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8580BF0", Offset = "0x857F5F0", VA = "0x188580BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private ODPAPHIFHIO NDMMKEMEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8580790", Offset = "0x857F190", VA = "0x188580790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x28ED770", Offset = "0x28EC170", VA = "0x1828ED770")]
	public DMPOKGCCDJN(CancellationToken JKPNCAGHEDI, HKFGPGHMLEK BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x85807E0", Offset = "0x857F1E0", VA = "0x1885807E0")]
	public static OBCGFPOCMIK GEPKEAHKKAD(HKFGPGHMLEK BPDOIFAEGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8580A90", Offset = "0x857F490", VA = "0x188580A90")]
	[AsyncStateMachine(typeof(LNEDLGHIMJA))]
	public Task<bool> IJLCGHNANIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8580580", Offset = "0x857EF80", VA = "0x188580580")]
	private bool BGJANGAFNLN([Out] BAMNMDPIDIE HGDFIMDKHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x85809C0", Offset = "0x857F3C0", VA = "0x1885809C0")]
	[AsyncStateMachine(typeof(IIODDNNMPDA))]
	private Task HOLFOCCLOPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8580890", Offset = "0x857F290", VA = "0x188580890")]
	private Task<PAICFMGKIHK> GGIFIPFDNHF(BAMNMDPIDIE AKLGOEOJAKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct PEODKHABLII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly LDFMNPJEPAK DHEFFMPMCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Guid CFNOFGNKICA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(MKIOIHPBAPC, Task)> MHEKPFJIGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x859B690", Offset = "0x859A090", VA = "0x18859B690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x526BFE0", Offset = "0x526A9E0", VA = "0x18526BFE0")]
	public PEODKHABLII(LDFMNPJEPAK DHEFFMPMCGH, Guid CFNOFGNKICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x859B640", Offset = "0x859A040", VA = "0x18859B640")]
	public TaskAwaiter<(MKIOIHPBAPC, Task)> KGCPCIIMFBP()
	{
		return default(TaskAwaiter<(MKIOIHPBAPC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x859B570", Offset = "0x8599F70", VA = "0x18859B570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct GDPGHAPEHJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly TaskCompletionSource<(MKIOIHPBAPC, Task)> JAHIGKAFBDH;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(MKIOIHPBAPC, Task)> MHEKPFJIGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8582600", Offset = "0x8581000", VA = "0x188582600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8582640", Offset = "0x8581040", VA = "0x188582640")]
	public GDPGHAPEHJE(TimeSpan PFDFCFFBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8582560", Offset = "0x8580F60", VA = "0x188582560")]
	public void LAKDJKHOMHN(Task DJBIHPNKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8582440", Offset = "0x8580E40", VA = "0x188582440")]
	public void GKMCALKBANB(MKIOIHPBAPC CNFJLDGBMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x85823F0", Offset = "0x8580DF0", VA = "0x1885823F0")]
	public void FOEJFFAGHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x85824D0", Offset = "0x8580ED0", VA = "0x1885824D0")]
	internal void KHKOMGAMJMA(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class JAGFPONPAAP
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x858C360", Offset = "0x858AD60", VA = "0x18858C360")]
	public static JKKKLGNDOCB AELMMJMLCNI(this JKKKLGNDOCB MGDBGDNLMCM, PFLGPOLCCPC LPPMCOCLDEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x858C500", Offset = "0x858AF00", VA = "0x18858C500")]
	public static JKKKLGNDOCB MCJHPLDJDIL(this JKKKLGNDOCB MGDBGDNLMCM, KNOKFGDBNBL GOMENBAKLCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class NBJHGBCNMAI : IAGCFAJDJGB
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GPEGJIIBJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KNOKFGDBNBL subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GPEGJIIBJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8588960", Offset = "0x8587360", VA = "0x188588960")]
		internal bool DHMFPOHKIAK(BBAIIGBMJIM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly NJLIBBEKNGN EGGFPNDBKDG;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public NBJHGBCNMAI(NJLIBBEKNGN DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8593F40", Offset = "0x8592940", VA = "0x188593F40", Slot = "4")]
	public JKKKLGNDOCB JEBOFNEMEAN(long BHJHEKIDPID, long IIHAMPMIGID, string DPKNLEFMODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8593FD0", Offset = "0x85929D0", VA = "0x188593FD0", Slot = "5")]
	public JKKKLGNDOCB JEBOFNEMEAN(long BHJHEKIDPID, long IIHAMPMIGID, LKFLNLIEOOH OHHJLEDHKKJ, Guid? DNAKELKDJFC, long OHKJMOJNDCK, bool FDGMGDOMFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8594130", Offset = "0x8592B30", VA = "0x188594130", Slot = "6")]
	public JKKKLGNDOCB JEBOFNEMEAN(LOKCFGIBPOM LNAHBLGNONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8593C60", Offset = "0x8592660", VA = "0x188593C60", Slot = "7")]
	public JKKKLGNDOCB JEBOFNEMEAN(PFLGPOLCCPC PHIAJLKAMFE, KNOKFGDBNBL PGOIIKFLMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8593BB0", Offset = "0x85925B0", VA = "0x188593BB0")]
	private Guid? EMLJBOBCEJJ(PFLGPOLCCPC APGBOIPHOGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class BLJCFPABGHH : CLEBFCONPFG, PBPILMLJLCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct KFLPJNCFDJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public BLJCFPABGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x858D3F0", Offset = "0x858BDF0", VA = "0x18858D3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x858DA80", Offset = "0x858C480", VA = "0x18858DA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly EPPGEGDDHJJ DHBHMKDEHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private string KACGNKNMIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Task DGIKPPOFKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool FHHGMDJMLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x857F9A0", Offset = "0x857E3A0", VA = "0x18857F9A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task DGODNJKNIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x857F9D0", Offset = "0x857E3D0", VA = "0x18857F9D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0", Slot = "7")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x857FA60", Offset = "0x857E460", VA = "0x18857FA60", Slot = "6")]
	public void MGGCMONJFME(Task HAAEKADIBMM, string JCLDEGBMKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x857FBC0", Offset = "0x857E5C0", VA = "0x18857FBC0")]
	[AsyncStateMachine(typeof(KFLPJNCFDJP))]
	private Task OFLGGBJJMIF(Task HLOAFHIINCL, string JCLDEGBMKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x857FCE0", Offset = "0x857E6E0", VA = "0x18857FCE0")]
	public BLJCFPABGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class JDJENDBMHNO : KBAKMBAAPLC, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool OLECBLKOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private OIOAOOLIIFE MAPJOIDLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private NJLIBBEKNGN DHADAJLMNNE;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OIOAOOLIIFE MONAHCODJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x858CA00", Offset = "0x858B400", VA = "0x18858CA00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x858C6D0", Offset = "0x858B0D0", VA = "0x18858C6D0", Slot = "7")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x858C850", Offset = "0x858B250", VA = "0x18858C850", Slot = "5")]
	public void FCPEJMIGJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x858C690", Offset = "0x858B090", VA = "0x18858C690", Slot = "6")]
	public void BIDKDNBOPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x858CA70", Offset = "0x858B470", VA = "0x18858CA70")]
	private Task NBPGIOHJHNF(JBJFMFIIGLG FHFGMILAALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x858C690", Offset = "0x858B090", VA = "0x18858C690", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JDJENDBMHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class GFCFJPLCDPF : NJLIBBEKNGN
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class LDMADMNHFAF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly JJPMOJNHOLC CCEMKGCMKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly string KJNEHANBOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly T ALKDPGOIFPD;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA979E0", Offset = "0xA963E0", VA = "0x180A979E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5278560", Offset = "0x5276F60", VA = "0x185278560")]
		public LDMADMNHFAF(JJPMOJNHOLC CCEMKGCMKEF, string KJNEHANBOBO, T ALKDPGOIFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5277D00", Offset = "0x5276700", VA = "0x185277D00")]
		private void KDJNBLGGOJF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly JJPMOJNHOLC CCEMKGCMKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly LDMADMNHFAF<TimeSpan> NGKMIHLKKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly LDMADMNHFAF<TimeSpan> CFCJKBBJFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly LDMADMNHFAF<TimeSpan> NOGIFPPOHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly LDMADMNHFAF<TimeSpan> NIGMDCBFHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly LDMADMNHFAF<bool> BHHODCNLMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly LDMADMNHFAF<bool> DJKBLJJCDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly LDMADMNHFAF<bool> BMMOMCMIOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly LDMADMNHFAF<int> PDJIFCONAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly LDMADMNHFAF<bool> MPAEFPFELJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly LDMADMNHFAF<bool> KANMJKDMEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly LDMADMNHFAF<IGNJONDMFAO> MPEMIAKGKJF;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan LIJKILNJGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8582800", Offset = "0x8581200", VA = "0x188582800", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan LLOBECNDHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8582990", Offset = "0x8581390", VA = "0x188582990", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan LFAKIGJGMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8582A10", Offset = "0x8581410", VA = "0x188582A10", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan CMEFKKFOLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x85829D0", Offset = "0x85813D0", VA = "0x1885829D0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool EHGHKAJNFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8582950", Offset = "0x8581350", VA = "0x188582950", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KFLJOBEIJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x85827C0", Offset = "0x85811C0", VA = "0x1885827C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PFMNHPJKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8582A50", Offset = "0x8581450", VA = "0x188582A50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int EFAMICDJOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8582910", Offset = "0x8581310", VA = "0x188582910", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KOJAPBGPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x85828D0", Offset = "0x85812D0", VA = "0x1885828D0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OHHKHLDCLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8582840", Offset = "0x8581240", VA = "0x188582840", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool KOBOFFOHONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8582880", Offset = "0x8581280", VA = "0x188582880", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8582A90", Offset = "0x8581490", VA = "0x188582A90")]
	[UnityEngine.Scripting.Preserve]
	public GFCFJPLCDPF([CNHMBDDCGKB(null)] JJPMOJNHOLC CCEMKGCMKEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class CLIHJKHPFHD : IOLIOOGCIMH, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class HMIGMFJEFMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public NPPCBBFHGKB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HMIGMFJEFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8589430", Offset = "0x8587E30", VA = "0x188589430")]
		internal object LILOJCBAALP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event NHALNBDKBHG KONMKGPAFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x857FEC0", Offset = "0x857E8C0", VA = "0x18857FEC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x857FF60", Offset = "0x857E960", VA = "0x18857FF60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NHALNBDKBHG AFDDABFLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x85800A0", Offset = "0x857EAA0", VA = "0x1885800A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x857FE20", Offset = "0x857E820", VA = "0x18857FE20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event NHALNBDKBHG KGDOKIJGKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8580000", Offset = "0x857EA00", VA = "0x188580000", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8580460", Offset = "0x857EE60", VA = "0x188580460", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HPJOEAHNKPG, bool> MGHJOPAPNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8580170", Offset = "0x857EB70", VA = "0x188580170", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x857FD70", Offset = "0x857E770", VA = "0x18857FD70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "16")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8580500", Offset = "0x857EF00", VA = "0x188580500", Slot = "12")]
	public void MGAJCJIFLPC(NPPCBBFHGKB MAHHBHOMIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8580140", Offset = "0x857EB40", VA = "0x188580140", Slot = "13")]
	public void ICKHAMDMHPN(NPPCBBFHGKB MAHHBHOMIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8580220", Offset = "0x857EC20", VA = "0x188580220", Slot = "14")]
	public void KHFKFNAEDBB(NPPCBBFHGKB MAHHBHOMIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8580250", Offset = "0x857EC50", VA = "0x188580250", Slot = "15")]
	public void LAMEKNEBHII(HPJOEAHNKPG OFENPOIFLNA, bool CACGHLMLDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x85802A0", Offset = "0x857ECA0", VA = "0x1885802A0")]
	private void LPGMHIBJMOO(NHALNBDKBHG NGGCDDHMKBK, NPPCBBFHGKB MAHHBHOMIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public CLIHJKHPFHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class IHBJGOJDGGP : PDIGPGJLKNI, PBPILMLJLCM, IDisposable, LHBDCPKFGEO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class PHHKCCIPDAE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct FBJKFCFHJPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public PHHKCCIPDAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public LHBDCPKFGEO.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private EJBJHLMGBBN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private GKBHAPPJEJE[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private TaskAwaiter<GKBHAPPJEJE.GHFHOEMFPLO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x8581170", Offset = "0x857FB70", VA = "0x188581170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x85818A0", Offset = "0x85802A0", VA = "0x1885818A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct LAAODCNEGKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public AsyncTaskMethodBuilder<GKBHAPPJEJE.GHFHOEMFPLO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public GKBHAPPJEJE fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public PHHKCCIPDAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public LHBDCPKFGEO.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private EJBJHLMGBBN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private KNNNJDGNAMM <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private TaskAwaiter<GKBHAPPJEJE.GHFHOEMFPLO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x858E530", Offset = "0x858CF30", VA = "0x18858E530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x858F1C0", Offset = "0x858DBC0", VA = "0x18858F1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class MBKNBNBOEIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public GKBHAPPJEJE fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public MBKNBNBOEIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x85922D0", Offset = "0x8590CD0", VA = "0x1885922D0")]
			internal object IDNLHJBKBOI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Task HAAEKADIBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationTokenSource LCAAPFCGOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public KNNNJDGNAMM BPDLJMIPDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EJALGCLEMLF FLJMNPJIKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MNEFCBHAIEP HNADNDMLMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AKIBJNGPBHA HDBNMLIMHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GKBHAPPJEJE[] DCBICCBKOKI;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool CMMJBHMPAEK
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x858DF70", Offset = "0x858C970", VA = "0x18858DF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool BLMFCLJEMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x858DF90", Offset = "0x858C990", VA = "0x18858DF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x859D270", Offset = "0x859BC70", VA = "0x18859D270")]
		public PHHKCCIPDAE(EJALGCLEMLF FLJMNPJIKOM, MNEFCBHAIEP HNADNDMLMAO, AKIBJNGPBHA HDBNMLIMHPI, GKBHAPPJEJE[] DCBICCBKOKI, CancellationToken JKPNCAGHEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x859BC40", Offset = "0x859A640", VA = "0x18859BC40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x859CC00", Offset = "0x859B600", VA = "0x18859CC00")]
		public void OCPAEDLJIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x859CC70", Offset = "0x859B670", VA = "0x18859CC70")]
		public void PADDJLPOAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x859BDD0", Offset = "0x859A7D0", VA = "0x18859BDD0")]
		public void EGBALPDDFPF(LHBDCPKFGEO.Reason DPFHGBBOBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x859C130", Offset = "0x859AB30", VA = "0x18859C130")]
		[AsyncStateMachine(typeof(FBJKFCFHJPI))]
		public Task ENJHNKJMJEA(LHBDCPKFGEO.Reason CHGJGNFMEJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x859C230", Offset = "0x859AC30", VA = "0x18859C230")]
		[AsyncStateMachine(typeof(LAAODCNEGKN))]
		private Task<GKBHAPPJEJE.GHFHOEMFPLO> GLHHLDLOKDL(LHBDCPKFGEO.Reason CHGJGNFMEJJ, GKBHAPPJEJE AEIMGEMKNLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x859BB20", Offset = "0x859A520", VA = "0x18859BB20")]
		private void CDEMIBAPCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x859C080", Offset = "0x859AA80", VA = "0x18859C080")]
		public bool EMIDNCGMMEE(LHBDCPKFGEO.Reason HBJDCIMNBGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x859C7F0", Offset = "0x859B1F0", VA = "0x18859C7F0")]
		private void NCAIKPOMLLH(KNNNJDGNAMM LOPOEJHIPKN, LHBDCPKFGEO.Reason CHGJGNFMEJJ = LHBDCPKFGEO.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x859C480", Offset = "0x859AE80", VA = "0x18859C480")]
		private void LLFHEGCGODB(KNNNJDGNAMM LOPOEJHIPKN, GKBHAPPJEJE.GHFHOEMFPLO MGJNMKLFKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x859C650", Offset = "0x859B050", VA = "0x18859C650")]
		private void MELEACNPOCF(KNNNJDGNAMM LOPOEJHIPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x859B760", Offset = "0x859A160", VA = "0x18859B760")]
		private void AECMAMLAKMG(KNNNJDGNAMM LOPOEJHIPKN, GKBHAPPJEJE.GHFHOEMFPLO MGJNMKLFKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x859CAA0", Offset = "0x859B4A0", VA = "0x18859CAA0")]
		private void NKEJJEGCCCK(KNNNJDGNAMM LOPOEJHIPKN, Exception AGKNBEAOFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x859C370", Offset = "0x859AD70", VA = "0x18859C370")]
		private void JLNDELLPKOE(GKBHAPPJEJE AEIMGEMKNLK, LHBDCPKFGEO.Reason CHGJGNFMEJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x859CDD0", Offset = "0x859B7D0", VA = "0x18859CDD0")]
		private void PKHEJCCLBGL(GKBHAPPJEJE AEIMGEMKNLK, LHBDCPKFGEO.Reason CHGJGNFMEJJ, string CJHKMCKHMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x859CEE0", Offset = "0x859B8E0", VA = "0x18859CEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class KNNNJDGNAMM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Task<GKBHAPPJEJE.GHFHOEMFPLO> HAAEKADIBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationTokenSource LCAAPFCGOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GKBHAPPJEJE AEIMGEMKNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public LHBDCPKFGEO.Reason DPFHGBBOBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public HashSet<LHBDCPKFGEO.Reason> JDAJNAHEBMP;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool CMMJBHMPAEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x858DF70", Offset = "0x858C970", VA = "0x18858DF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool BLMFCLJEMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x858DF90", Offset = "0x858C990", VA = "0x18858DF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x858DFD0", Offset = "0x858C9D0", VA = "0x18858DFD0")]
		public void JCMHGMGGFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x858DFB0", Offset = "0x858C9B0", VA = "0x18858DFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x858E130", Offset = "0x858CB30", VA = "0x18858E130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x858E4A0", Offset = "0x858CEA0", VA = "0x18858E4A0")]
		public KNNNJDGNAMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class BBPGDGNKGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public LHBDCPKFGEO.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BBPGDGNKGBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x857DF70", Offset = "0x857C970", VA = "0x18857DF70")]
		internal object FCICELDJILP(KNNNJDGNAMM x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x857E050", Offset = "0x857CA50", VA = "0x18857E050")]
		internal object HJEGOAGICPL(PHHKCCIPDAE x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x857DFE0", Offset = "0x857C9E0", VA = "0x18857DFE0")]
		internal object GOABIELAJNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct LOJOMDLPALI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public LHBDCPKFGEO.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public IHBJGOJDGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private BBPGDGNKGBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8591490", Offset = "0x858FE90", VA = "0x188591490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8591EF0", Offset = "0x85908F0", VA = "0x188591EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct BLINADFOGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IHBJGOJDGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public LHBDCPKFGEO.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private PHHKCCIPDAE <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x857ECD0", Offset = "0x857D6D0", VA = "0x18857ECD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x857F940", Offset = "0x857E340", VA = "0x18857F940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct OLPPKPEONGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IHBJGOJDGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8599500", Offset = "0x8597F00", VA = "0x188599500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8599A70", Offset = "0x8598470", VA = "0x188599A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	internal static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal static readonly COJJKFBGGKB EMCBKLDNNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PHHKCCIPDAE COMAFPPEADH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x858A350", Offset = "0x8588D50", VA = "0x18858A350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool MNEBJELMDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x252DCD0", Offset = "0x252C6D0", VA = "0x18252DCD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool JLMLNBKFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8589A30", Offset = "0x8588430", VA = "0x188589A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8589AA0", Offset = "0x85884A0", VA = "0x188589AA0", Slot = "6")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8589C30", Offset = "0x8588630", VA = "0x188589C30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x858A1D0", Offset = "0x8588BD0", VA = "0x18858A1D0", Slot = "9")]
	public void JCMHGMGGFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8589950", Offset = "0x8588350", VA = "0x188589950")]
	private bool APBHNINCFIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x858A3A0", Offset = "0x8588DA0", VA = "0x18858A3A0", Slot = "5")]
	private void PGFCADJPOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x858A010", Offset = "0x8588A10", VA = "0x18858A010", Slot = "8")]
	[AsyncStateMachine(typeof(LOJOMDLPALI))]
	public Task GIAMBKJGLJN(LHBDCPKFGEO.Reason CHGJGNFMEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x858A470", Offset = "0x8588E70", VA = "0x18858A470")]
	private bool PMGAKFEFMHO(LHBDCPKFGEO.Reason CHGJGNFMEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8589C40", Offset = "0x8588640", VA = "0x188589C40")]
	private GKBHAPPJEJE[] FHCHKJJAJJA(AKIBJNGPBHA KPMIIEGAOPE, MNEFCBHAIEP CKIMIPJKGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8589B20", Offset = "0x8588520", VA = "0x188589B20")]
	[AsyncStateMachine(typeof(BLINADFOGGJ))]
	private Task DIHKCEMOABK(LHBDCPKFGEO.Reason CHGJGNFMEJJ, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x858A100", Offset = "0x8588B00", VA = "0x18858A100")]
	[AsyncStateMachine(typeof(OLPPKPEONGF))]
	private Task HJJDOMGNNED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IHBJGOJDGGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class NFBMHGJHMKH : LLJMALKPDCO, PBPILMLJLCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct NCOBMFBIIAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public EFLDNNPDEGB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8594330", Offset = "0x8592D30", VA = "0x188594330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8594C90", Offset = "0x8593690", VA = "0x188594C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LHLOMJKHELA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public EFLDNNPDEGB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private JBLIEDANKLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private EJBJHLMGBBN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private GIPKKFBMGMB <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private OAPINCBOEGG <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x858F230", Offset = "0x858DC30", VA = "0x18858F230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8590380", Offset = "0x858ED80", VA = "0x188590380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class FJJNOCCCNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public Matchmaking.BIEOCDGGFMF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FFMJGFGHNFM errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FJJNOCCCNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8582340", Offset = "0x8580D40", VA = "0x188582340")]
		internal object GFCIPNFDKPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JPCMOELMDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Task<JKKKLGNDOCB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JPCMOELMDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		internal Task<JKKKLGNDOCB> KHAGAPLKLEF(JBLIEDANKLD<string>.CKADLEMJOGG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct GGMHPIIFCPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public EFLDNNPDEGB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public GIPKKFBMGMB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private JPCMOELMDBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private BMDFAIOFFAL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private EJBJHLMGBBN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private NEKLIGKEFGE <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private Task<Matchmaking.PHGBJKEPAAK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private AOGCLKAMMAP <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<Matchmaking.PHGBJKEPAAK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<JKKKLGNDOCB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8582F60", Offset = "0x8581960", VA = "0x188582F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x85888C0", Offset = "0x85872C0", VA = "0x1885888C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FCFBOFNDGMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task<JKKKLGNDOCB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FCFBOFNDGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		internal Task<JKKKLGNDOCB> AMOOOIFFAFP(JBLIEDANKLD<string>.CKADLEMJOGG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct KIGBEJJODHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public EFLDNNPDEGB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public GIPKKFBMGMB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private BMDFAIOFFAL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EJBJHLMGBBN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private NEKLIGKEFGE <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Task<Matchmaking.PHGBJKEPAAK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private JKKKLGNDOCB <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private ALOJOEEMFDJ <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<JKKKLGNDOCB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private AOGCLKAMMAP <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private KFGFFEGGOPH <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private NEFKBOAAHCB <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter<FKNMGFLNFFM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter<Matchmaking.PHGBJKEPAAK> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x85ABB20", Offset = "0x85AA520", VA = "0x1885ABB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x85B1190", Offset = "0x85AFB90", VA = "0x1885B1190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct ALALBHFOEMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x85A0680", Offset = "0x859F080", VA = "0x1885A0680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x85A10F0", Offset = "0x859FAF0", VA = "0x1885A10F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct GKCNDFFKBMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private MHGNCMHMEKD <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x85A72B0", Offset = "0x85A5CB0", VA = "0x1885A72B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x85A7740", Offset = "0x85A6140", VA = "0x1885A7740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IPFLIIKGEKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder<Matchmaking.PHGBJKEPAAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TaskAwaiter<Matchmaking.PHGBJKEPAAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x85AB0A0", Offset = "0x85A9AA0", VA = "0x1885AB0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x85AB580", Offset = "0x85A9F80", VA = "0x1885AB580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct NFGCNCGOBNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Matchmaking.PHGBJKEPAAK serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public GIPKKFBMGMB joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<HEGFDOKDCFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x85B9130", Offset = "0x85B7B30", VA = "0x1885B9130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x85B9770", Offset = "0x85B8170", VA = "0x1885B9770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class JPMKHCOOOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JPMKHCOOOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x85AB850", Offset = "0x85AA250", VA = "0x1885AB850")]
		internal object KEEKODHENGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x85AB750", Offset = "0x85AA150", VA = "0x1885AB750")]
		internal string GOHCGGEBPDE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct EICLCKGKHDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private JPMKHCOOOBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x85A4390", Offset = "0x85A2D90", VA = "0x1885A4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x85A4F30", Offset = "0x85A3930", VA = "0x1885A4F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct HJLDKLFIILB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public GIPKKFBMGMB joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public JKKKLGNDOCB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AKIBJNGPBHA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public ALOJOEEMFDJ preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public BMDFAIOFFAL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x85A94E0", Offset = "0x85A7EE0", VA = "0x1885A94E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x85A9CD0", Offset = "0x85A86D0", VA = "0x1885A9CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct MEMHOFGOBMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private EJBJHLMGBBN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private EJBJHLMGBBN <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x85B39C0", Offset = "0x85B23C0", VA = "0x1885B39C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x85B51A0", Offset = "0x85B3BA0", VA = "0x1885B51A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct FDADJKNPOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public IIOJHPILAFO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public NFBMHGJHMKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter<MKIOIHPBAPC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x85A4F90", Offset = "0x85A3990", VA = "0x1885A4F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x85A5790", Offset = "0x85A4190", VA = "0x1885A5790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class KGMGCNPDAKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KGMGCNPDAKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x85AB950", Offset = "0x85AA350", VA = "0x1885AB950")]
		internal object AHNGNBCLACG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class IACMCCIBGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IACMCCIBGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x85AA030", Offset = "0x85A8A30", VA = "0x1885AA030")]
		internal void HBGIKPNGJBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class PFLOBIDBNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PFLOBIDBNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x85BBFE0", Offset = "0x85BA9E0", VA = "0x1885BBFE0")]
		internal object HBFGFBEEHEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LCLLMCKANCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LCLLMCKANCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x85B1260", Offset = "0x85AFC60", VA = "0x1885B1260")]
		internal string LFIEBIOBABG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly COJJKFBGGKB JDMEIGCIDJC;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly COJJKFBGGKB DBANDCANOCA;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly COJJKFBGGKB EKDCGKCMAIB;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly string DNIBJOEGGOG;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly string PMOHGAKPJNN;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly string MCBKMDGALLO;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly Guid MIKGEGNELIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private EGNOIGEDNKF DOGCKMIKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private IMKJJHDGMOH IKHNLLNHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private PDIGPGJLKNI HIFPDJJHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private CLEBFCONPFG GAGBBFPHMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private IOLIOOGCIMH GKEBBNCFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private LMPNAOLEGDD HOEJKEDGJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private ECDKCDAMMIP CBDBIJBBDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private IDisposable GICKINDGBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private EANLFKMKDNP GADHCLBNLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly EPPGEGDDHJJ GMCMJGLOMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private AOGCLKAMMAP JLAFADBCHKD;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus KOJOBLAJMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA320F0", Offset = "0xA30AF0", VA = "0x180A320F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x143B230", Offset = "0x1439C30", VA = "0x18143B230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8597DC0", Offset = "0x85967C0", VA = "0x188597DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x8595ED0", Offset = "0x85948D0", VA = "0x188595ED0", Slot = "6")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8596530", Offset = "0x8594F30", VA = "0x188596530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8596580", Offset = "0x8594F80", VA = "0x188596580", Slot = "5")]
	[AsyncStateMachine(typeof(NCOBMFBIIAH))]
	public Task EANNGIPCDCO(AKIBJNGPBHA JAOKMPOOJCM, EFLDNNPDEGB MBJMPJODHJI, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8598020", Offset = "0x8596A20", VA = "0x188598020")]
	[AsyncStateMachine(typeof(LHLOMJKHELA))]
	private Task NIMCJNGCMKK(AKIBJNGPBHA JAOKMPOOJCM, EFLDNNPDEGB MBJMPJODHJI, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x85969A0", Offset = "0x85953A0", VA = "0x1885969A0")]
	private void EPPNILGIMIE(LMPNAOLEGDD HOEJKEDGJHM, AKIBJNGPBHA JAOKMPOOJCM, Exception AGKNBEAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8595150", Offset = "0x8593B50", VA = "0x188595150")]
	private static void AGDJOCMEEBE(OAPINCBOEGG BEIMDNOPGHM, Exception AGKNBEAOFAM, [Optional] List<int> KAFJHGOEGPF, int FBNHHJDGICD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8597C60", Offset = "0x8596660", VA = "0x188597C60")]
	[AsyncStateMachine(typeof(GGMHPIIFCPG))]
	private Task LKPAKPKOENN(JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, AKIBJNGPBHA JAOKMPOOJCM, EFLDNNPDEGB MBJMPJODHJI, GIPKKFBMGMB DPGECCDPBCB, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x85983F0", Offset = "0x8596DF0", VA = "0x1885983F0")]
	[AsyncStateMachine(typeof(KIGBEJJODHE))]
	private Task OOGFJBLLEBM(JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, AKIBJNGPBHA JAOKMPOOJCM, EFLDNNPDEGB MBJMPJODHJI, GIPKKFBMGMB DPGECCDPBCB, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8597A50", Offset = "0x8596450", VA = "0x188597A50")]
	private void LDHBNJKHLIP([CallerMemberName] string DHECPPHFPLD = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8596870", Offset = "0x8595270", VA = "0x188596870")]
	[AsyncStateMachine(typeof(ALALBHFOEMK))]
	private Task EKABJGEHHEC(JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8595970", Offset = "0x8594370", VA = "0x188595970")]
	private void AOIOIDJIFDC(AKIBJNGPBHA JAOKMPOOJCM, CancellationToken IFGGPDNONLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8598550", Offset = "0x8596F50", VA = "0x188598550")]
	private void PJBFOEEMCJK(AKIBJNGPBHA JAOKMPOOJCM, TaskStatus AEMGNCBHNDC, string IJOJGNJMCGP, GIPKKFBMGMB DPGECCDPBCB, Exception EMKLCNOEBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x85979D0", Offset = "0x85963D0", VA = "0x1885979D0")]
	private void KNLLHDJOJDN(AKIBJNGPBHA JAOKMPOOJCM, GIPKKFBMGMB DPGECCDPBCB, OperationCanceledException KMPHDEFPCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8597810", Offset = "0x8596210", VA = "0x188597810")]
	private void KBBIPLCICDG(AKIBJNGPBHA JAOKMPOOJCM, GIPKKFBMGMB DPGECCDPBCB, Exception AGKNBEAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8597E10", Offset = "0x8596810", VA = "0x188597E10")]
	private void NCNOMKPJGAK(AKIBJNGPBHA JAOKMPOOJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x85950F0", Offset = "0x8593AF0", VA = "0x1885950F0")]
	private static NPPCBBFHGKB ACMFOLAAJHO(AKIBJNGPBHA JAOKMPOOJCM)
	{
		return default(NPPCBBFHGKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x85975C0", Offset = "0x8595FC0", VA = "0x1885975C0")]
	[AsyncStateMachine(typeof(GKCNDFFKBMP))]
	private Task JIELKGEAOCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x85971D0", Offset = "0x8595BD0", VA = "0x1885971D0")]
	[AsyncStateMachine(typeof(IPFLIIKGEKG))]
	private Task<Matchmaking.PHGBJKEPAAK> GINLDPDHPOC(AKIBJNGPBHA JAOKMPOOJCM, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8594FE0", Offset = "0x85939E0", VA = "0x188594FE0")]
	private static HEGFDOKDCFO ABLGNFMOOON(Matchmaking.PHGBJKEPAAK BDIFBJCPLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x85963E0", Offset = "0x8594DE0", VA = "0x1885963E0")]
	[AsyncStateMachine(typeof(NFGCNCGOBNO))]
	private Task DPPAPDGEDOL(Matchmaking.PHGBJKEPAAK BDIFBJCPLOB, GIPKKFBMGMB DPGECCDPBCB, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken HHJEDBBMJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8596E10", Offset = "0x8595810", VA = "0x188596E10")]
	[AsyncStateMachine(typeof(EICLCKGKHDH))]
	private Task FFEGFNMIKBK(AKIBJNGPBHA JAOKMPOOJCM, CancellationTokenSource BLBPOEMEMEA, Task NPMKKDLILDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8597440", Offset = "0x8595E40", VA = "0x188597440")]
	[AsyncStateMachine(typeof(HJLDKLFIILB))]
	private Task JBCJDLNHJDN(JKKKLGNDOCB DCIMNMEKALL, BMDFAIOFFAL HPNEOCEEIHE, AKIBJNGPBHA CMMOIGEMMKH, GIPKKFBMGMB LPDNBDKCMNF, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken GKBAFKBMCJL, [Optional] ALOJOEEMFDJ GCDDKKMJIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x85961F0", Offset = "0x8594BF0", VA = "0x1885961F0")]
	private GIPKKFBMGMB DJFGGNIFOFJ(GIPKKFBMGMB LPDNBDKCMNF, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8597890", Offset = "0x8596290", VA = "0x188597890")]
	[AsyncStateMachine(typeof(MEMHOFGOBMA))]
	private Task KDJLEGJOGGD(JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x85982C0", Offset = "0x8596CC0", VA = "0x1885982C0")]
	[AsyncStateMachine(typeof(FDADJKNPOEO))]
	private Task OKAEJFCODOE(CancellationToken JKPNCAGHEDI, int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8596F50", Offset = "0x8595950", VA = "0x188596F50")]
	private static void FGLELKMMEME(AKIBJNGPBHA JAOKMPOOJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8595CA0", Offset = "0x85946A0", VA = "0x188595CA0")]
	private void CBICKOJBMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x85981D0", Offset = "0x8596BD0", VA = "0x1885981D0")]
	private void NNENCDEDMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8597BD0", Offset = "0x85965D0", VA = "0x188597BD0")]
	private void LIJOGPODCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8597690", Offset = "0x8596090", VA = "0x188597690")]
	private void JKBAFMELOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8597720", Offset = "0x8596120", VA = "0x188597720")]
	private static void JMOBJOAFFLF(AKIBJNGPBHA JAOKMPOOJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8597330", Offset = "0x8595D30", VA = "0x188597330")]
	private static CancellationTokenRegistration IOKGIGFBNDN(AKIBJNGPBHA JAOKMPOOJCM, CancellationToken HHJEDBBMJFB)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x85970D0", Offset = "0x8595AD0", VA = "0x1885970D0")]
	private static void FLFHDOMIFOC(AKIBJNGPBHA JAOKMPOOJCM, Exception AGKNBEAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x85966C0", Offset = "0x85950C0", VA = "0x1885966C0")]
	private void EJEJHNNCPJG(AKIBJNGPBHA JAOKMPOOJCM, Task NPMKKDLILDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8598170", Offset = "0x8596B70", VA = "0x188598170")]
	private static void NLLEOCMFOCP(Func<string> JPHCPKKNAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x85989B0", Offset = "0x85973B0", VA = "0x1885989B0")]
	public NFBMHGJHMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8598260", Offset = "0x8596C60", VA = "0x188598260")]
	[CompilerGenerated]
	internal static (int, int?) OILPLPGMKGC(FFMJGFGHNFM IPOOJEEDJGK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.NoEngine.Common.Preserve]
internal class PCMBIMHECKM : LHGEHMBEHHE, PBPILMLJLCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct GHLLFOAOPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public PCMBIMHECKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public IIOJHPILAFO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x85A5920", Offset = "0x85A4320", VA = "0x1885A5920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5E00", Offset = "0x85A4800", VA = "0x1885A5E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IEEPGKOBION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public PCMBIMHECKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public IIOJHPILAFO localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IEEPGKOBION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x85AA0D0", Offset = "0x85A8AD0", VA = "0x1885AA0D0")]
		internal List<Task> EILCEGINJCC(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct MOGMMGELOEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public OBCGFPOCMIK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public IIOJHPILAFO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x85B5540", Offset = "0x85B3F40", VA = "0x1885B5540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x85B58E0", Offset = "0x85B42E0", VA = "0x1885B58E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct MOEGPMJINJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public PCMBIMHECKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x85B5200", Offset = "0x85B3C00", VA = "0x1885B5200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x85B54E0", Offset = "0x85B3EE0", VA = "0x1885B54E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly HashSet<OBCGFPOCMIK> FEMIEPAPHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private IMKJJHDGMOH IKHNLLNHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private OACHJIOLDGM FFCIGMGEHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private DNEBAKJCLGP BDBOLBNDJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private IDisposable GICKINDGBLP;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x85BAF70", Offset = "0x85B9970", VA = "0x1885BAF70", Slot = "5")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x85BB250", Offset = "0x85B9C50", VA = "0x1885BB250", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x85BB380", Offset = "0x85B9D80", VA = "0x1885BB380", Slot = "4")]
	public bool GLKLACLKDJD(OBCGFPOCMIK DMEOEPFEMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x85BB3E0", Offset = "0x85B9DE0", VA = "0x1885BB3E0")]
	private void GOFMNBLPIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x85BB4B0", Offset = "0x85B9EB0", VA = "0x1885BB4B0")]
	private void IACOFJPAOMC(JFCHLDJHBKP NIAPBNPEIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x85BBC70", Offset = "0x85BA670", VA = "0x1885BBC70")]
	[AsyncStateMachine(typeof(GHLLFOAOPPF))]
	private Task LPCPPNJLGOF(int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x85BBD60", Offset = "0x85BA760", VA = "0x1885BBD60")]
	private Func<CancellationToken, List<Task>> MDICMIMMOFJ(int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x85BB750", Offset = "0x85BA150", VA = "0x1885BB750")]
	private List<Task> JFPHKLJLMAK(int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x85BBE30", Offset = "0x85BA830", VA = "0x1885BBE30")]
	[AsyncStateMachine(typeof(MOGMMGELOEC))]
	private Task PEFAIHOIJLE(OBCGFPOCMIK IHKJPCPFJEA, CancellationToken BECBHDDLOHA, int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x85BB2B0", Offset = "0x85B9CB0", VA = "0x1885BB2B0")]
	[AsyncStateMachine(typeof(MOEGPMJINJH))]
	private Task FFJMNKCDIIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x85BB6D0", Offset = "0x85BA0D0", VA = "0x1885BB6D0")]
	private void JCMHGMGGFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x85BBF50", Offset = "0x85BA950", VA = "0x1885BBF50")]
	public PCMBIMHECKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[UnityEngine.Scripting.Preserve]
internal sealed class LKNNGIIKKHJ : LDFMNPJEPAK, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class BCDHIAEPIKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BCDHIAEPIKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x85A11E0", Offset = "0x859FBE0", VA = "0x1885A11E0")]
		internal object BGHELDDMFFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class BGODMCLBGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BGODMCLBGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x85A1240", Offset = "0x859FC40", VA = "0x1885A1240")]
		internal object FNENODNPILL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class OCKBNMMMKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OCKBNMMMKFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class DNHMGCKMMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DNHMGCKMMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x85A38E0", Offset = "0x85A22E0", VA = "0x1885A38E0")]
		internal object KKFANKCEAOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class GOBHGBJOCAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GOBHGBJOCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x85A77A0", Offset = "0x85A61A0", VA = "0x1885A77A0")]
		internal object KCMNIHMJBGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private readonly Dictionary<Guid, GDPGHAPEHJE> DHEFFMPMCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly TimeSpan CBBDFJLEEHF;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "9")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x85B18A0", Offset = "0x85B02A0", VA = "0x1885B18A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x85B1B00", Offset = "0x85B0500", VA = "0x1885B1B00", Slot = "4")]
	public PEODKHABLII PBDMKLNODMP(Guid CFNOFGNKICA)
	{
		return default(PEODKHABLII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x85B1690", Offset = "0x85B0090", VA = "0x1885B1690", Slot = "5")]
	public bool DAAFLACHELB(Guid CFNOFGNKICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x85B1360", Offset = "0x85AFD60", VA = "0x1885B1360", Slot = "6")]
	public bool ANCAIOEGCMP(Guid CFNOFGNKICA, Task DJBIHPNKNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x85B1920", Offset = "0x85B0320", VA = "0x1885B1920", Slot = "7")]
	public bool GHIOHEEACHI(Guid CFNOFGNKICA, MKIOIHPBAPC CNFJLDGBMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x85B18B0", Offset = "0x85B02B0", VA = "0x1885B18B0", Slot = "8")]
	public Task<(MKIOIHPBAPC, Task)> FAKCCODIELP(Guid CFNOFGNKICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x85B1D20", Offset = "0x85B0720", VA = "0x1885B1D20")]
	private void PPDCNHMMKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x85B1F50", Offset = "0x85B0950", VA = "0x1885B1F50")]
	public LKNNGIIKKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.NoEngine.Common.Preserve]
internal class GIGODILBDDE : OALBFPOKLLG, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class GOGDGCONMDK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly AKIBJNGPBHA NJHMHPLAPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly CancellationTokenSource IFHBDAKCHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public readonly CancellationToken MPLMKKLDHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool NJFEDFJLHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private bool CDPHAALIFLC;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x85A7980", Offset = "0x85A6380", VA = "0x1885A7980")]
		public GOGDGCONMDK(AKIBJNGPBHA NJHMHPLAPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x85A7830", Offset = "0x85A6230", VA = "0x1885A7830")]
		public void JCMHGMGGFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x85A7800", Offset = "0x85A6200", VA = "0x1885A7800", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class AODLOLBGCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public JBJFMFIIGLG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AODLOLBGCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x85A1150", Offset = "0x859FB50", VA = "0x1885A1150")]
		internal object KNGMGMHIENA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct DPGGDMEDDOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public JBJFMFIIGLG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public GIGODILBDDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x85A3EE0", Offset = "0x85A28E0", VA = "0x1885A3EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x85A4330", Offset = "0x85A2D30", VA = "0x1885A4330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LCHKPPIAEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public GIGODILBDDE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LCHKPPIAEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x85B11F0", Offset = "0x85AFBF0", VA = "0x1885B11F0")]
		internal object HNGJCHALCJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class HHKNJLCJBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AKIBJNGPBHA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public LCHKPPIAEPK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HHKNJLCJBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x85A9420", Offset = "0x85A7E20", VA = "0x1885A9420")]
		internal object NCHPGJCPLMD((AKIBJNGPBHA lastLocalPlayerRoomInstance, AKIBJNGPBHA newRoomInstance, PDIGPGJLKNI fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct MPBHFCFBFPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public GIGODILBDDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private EJBJHLMGBBN <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x85B5AE0", Offset = "0x85B44E0", VA = "0x1885B5AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class MONOIOBKHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AKIBJNGPBHA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MONOIOBKHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x85B5980", Offset = "0x85B4380", VA = "0x1885B5980")]
		internal object DLJFGLCMEFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x85B5A60", Offset = "0x85B4460", VA = "0x1885B5A60")]
		internal void HILKDMDAGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x85B5A20", Offset = "0x85B4420", VA = "0x1885B5A20")]
		internal object EIGBOBMAPGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x85B5940", Offset = "0x85B4340", VA = "0x1885B5940")]
		internal object CPHEODKEJOK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct DHNEIALKHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AKIBJNGPBHA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public GIGODILBDDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public EFLDNNPDEGB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private MONOIOBKHGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x85A28D0", Offset = "0x85A12D0", VA = "0x1885A28D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x85A3880", Offset = "0x85A2280", VA = "0x1885A3880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly CCLALJOOBOK.PLOGIDDEOFN EEOOCEAIHBE;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly CHPALBDOOEK MJOCCDALHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private IMKJJHDGMOH IKHNLLNHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private PDIGPGJLKNI HIFPDJJHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private NJLIBBEKNGN DHADAJLMNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private LLJMALKPDCO JNKIODNFKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private AKIBJNGPBHA BMBBBPKADHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private GOGDGCONMDK ENNCFENCEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool HDNGHGANPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Task DEJKCNLHNCO;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x85A68E0", Offset = "0x85A52E0", VA = "0x1885A68E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool COCIENFGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xCF5530", Offset = "0xCF3F30", VA = "0x180CF5530")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x85A6EA0", Offset = "0x85A58A0", VA = "0x1885A6EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x85A60E0", Offset = "0x85A4AE0", VA = "0x1885A60E0", Slot = "4")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x85A6450", Offset = "0x85A4E50", VA = "0x1885A6450", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x85A6DB0", Offset = "0x85A57B0", VA = "0x1885A6DB0")]
	[AsyncStateMachine(typeof(DPGGDMEDDOD))]
	private Task PDNFLKLHJOB(JBJFMFIIGLG NOJMHGNOHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x85A6750", Offset = "0x85A5150", VA = "0x1885A6750")]
	private void LMIIIPJAOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x85A65C0", Offset = "0x85A4FC0", VA = "0x1885A65C0")]
	private void KFFMDDCAHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x85A5F60", Offset = "0x85A4960", VA = "0x1885A5F60")]
	private void CGJDAFPGKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85A6BC0", Offset = "0x85A55C0", VA = "0x1885A6BC0")]
	private bool MODGLCCDNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x85A6380", Offset = "0x85A4D80", VA = "0x1885A6380")]
	[AsyncStateMachine(typeof(MPBHFCFBFPG))]
	private void DLKNHGHBEHM(int BJBHFAMODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x85A6930", Offset = "0x85A5330", VA = "0x1885A6930")]
	private void MLLFILFMDNH([Out] IDisposable BMNNNGEIMAE, [Out] IDisposable JMEIADMHKGG, [Out] IDisposable FAONFNPBLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x85A5E60", Offset = "0x85A4860", VA = "0x1885A5E60")]
	private bool BFFDCNAPKHC(AKIBJNGPBHA NJHMHPLAPDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x85A6D60", Offset = "0x85A5760", VA = "0x1885A6D60")]
	private void NMDCFBKAKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x85A6C30", Offset = "0x85A5630", VA = "0x1885A6C30")]
	[AsyncStateMachine(typeof(DHNEIALKHGH))]
	private Task NIMCJNGCMKK(AKIBJNGPBHA NJHMHPLAPDF, EFLDNNPDEGB MBJMPJODHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x85A7240", Offset = "0x85A5C40", VA = "0x1885A7240")]
	public GIGODILBDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[UnityEngine.Scripting.Preserve]
internal sealed class HCOLLOIMAMN : JPBJLLNELNA, PBPILMLJLCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct HLBGAJDIJOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<KCGEDCCFACD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HCOLLOIMAMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<KCGEDCCFACD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x85A9D30", Offset = "0x85A8730", VA = "0x1885A9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x85A9FC0", Offset = "0x85A89C0", VA = "0x1885A9FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OAPMEMBNNEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public OBIDIGOJIIL message;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OAPMEMBNNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x85BA100", Offset = "0x85B8B00", VA = "0x1885BA100")]
		internal object BLLKNLMCAAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class JBNOJFFGDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public OBIDIGOJIIL messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JBNOJFFGDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x85AB5F0", Offset = "0x85A9FF0", VA = "0x1885AB5F0")]
		internal object DJEEAKINCAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class GEHNBHCJCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GEHNBHCJCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x85A58C0", Offset = "0x85A42C0", VA = "0x1885A58C0")]
		internal object ADMKMHCCIFC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct IOEALMEHJNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public HCOLLOIMAMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private TaskAwaiter<CPEALFJADBF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x85AA770", Offset = "0x85A9170", VA = "0x1885AA770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x85AB040", Offset = "0x85A9A40", VA = "0x1885AB040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class JIJMLDPAEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public OBIDIGOJIIL operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JIJMLDPAEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x85AB6B0", Offset = "0x85AA0B0", VA = "0x1885AB6B0")]
		internal object HALLCAODGBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct AFFGHLFPKHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public OBIDIGOJIIL operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public HCOLLOIMAMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private GIPKKFBMGMB <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x859EE70", Offset = "0x859D870", VA = "0x18859EE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x859F9E0", Offset = "0x859E3E0", VA = "0x18859F9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct DOIDAJLMMIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<CPEALFJADBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public HCOLLOIMAMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private KMPPFKMNDEG.LHBIFNNGIHF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private GIPKKFBMGMB <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x85A3940", Offset = "0x85A2340", VA = "0x1885A3940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x85A3E70", Offset = "0x85A2870", VA = "0x1885A3E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class CGJBJLLDMFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CPEALFJADBF operation;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CGJBJLLDMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x85A2690", Offset = "0x85A1090", VA = "0x1885A2690")]
		internal object DJLJAKFEPBC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct NHJCCJBEIFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CPEALFJADBF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public HCOLLOIMAMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private JBLIEDANKLD<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x85B9A60", Offset = "0x85B8460", VA = "0x1885B9A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x85BA0A0", Offset = "0x85B8AA0", VA = "0x1885BA0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class JCFJENLEOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JCFJENLEOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x85AB650", Offset = "0x85AA050", VA = "0x1885AB650")]
		internal object HCKFJAGOAFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class OJHMPGGBEGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OJHMPGGBEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x85BA7E0", Offset = "0x85B91E0", VA = "0x1885BA7E0")]
		internal object CBFCHPCLBBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private CLEBFCONPFG GAGBBFPHMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private POOAGLCFPBF NMLIHFBGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private BAGBLNJGMFA EMNEDFGECOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private TaskCompletionSource<KCGEDCCFACD> NGEBPKJKGDF;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x85A8180", Offset = "0x85A6B80", VA = "0x1885A8180", Slot = "7")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x85A8B90", Offset = "0x85A7590", VA = "0x1885A8B90", Slot = "6")]
	[AsyncStateMachine(typeof(HLBGAJDIJOK))]
	public Task<KCGEDCCFACD> IPKOCAEJNPA(CancellationToken PFAKIDAFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x85A9090", Offset = "0x85A7A90", VA = "0x1885A9090", Slot = "4")]
	public void NFPLIFLACKN(OBIDIGOJIIL IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x85A8830", Offset = "0x85A7230", VA = "0x1885A8830", Slot = "5")]
	public void IAPPCNLMBDF(OBIDIGOJIIL HKJEJLMPCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x85A8720", Offset = "0x85A7120", VA = "0x1885A8720")]
	[AsyncStateMachine(typeof(IOEALMEHJNA))]
	private Task FPMGAIIFLGP(OBIDIGOJIIL OHOKHLNBDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x85A8070", Offset = "0x85A6A70", VA = "0x1885A8070")]
	[AsyncStateMachine(typeof(AFFGHLFPKHK))]
	private Task CABJPDOOFCB(OBIDIGOJIIL AOLMLKPEBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x85A8F40", Offset = "0x85A7940", VA = "0x1885A8F40")]
	[AsyncStateMachine(typeof(DOIDAJLMMIH))]
	private Task<CPEALFJADBF> KPOKCNGFKLD(OBIDIGOJIIL OHOKHLNBDDB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x85A8EB0", Offset = "0x85A78B0", VA = "0x1885A8EB0")]
	private GIPKKFBMGMB KMLDCCHJEFB(OBIDIGOJIIL AGAELLMOCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x85A8600", Offset = "0x85A7000", VA = "0x1885A8600")]
	[AsyncStateMachine(typeof(NHJCCJBEIFM))]
	private Task EDIEDCEENML(CPEALFJADBF GNLEPFMJLKI, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x85A8CA0", Offset = "0x85A76A0", VA = "0x1885A8CA0")]
	private CPEALFJADBF JPBPIKJHFBE(OBIDIGOJIIL OHOKHLNBDDB, GIPKKFBMGMB NAFHMMBAILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B950", Offset = "0x3A7A350", VA = "0x183A7B950")]
	private T CIEIMKHOKLD<T>(T PCDAHJCDHHF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x85A8270", Offset = "0x85A6C70", VA = "0x1885A8270")]
	private CPEALFJADBF DMOLBOJODGM(OBIDIGOJIIL OHOKHLNBDDB, GIPKKFBMGMB NAFHMMBAILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public HCOLLOIMAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class MPLLINLLJFO : POOAGLCFPBF, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class CKDJLPOEFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CKDJLPOEFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x85A2860", Offset = "0x85A1260", VA = "0x1885A2860")]
		internal object LFFKPOMHCGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class FFLBOCDPPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FFLBOCDPPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x85A57F0", Offset = "0x85A41F0", VA = "0x1885A57F0")]
		internal object PEBPLLAFNNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private HIOIBLBFHFA HIDLGKOCDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private JPBJLLNELNA LEEMLFCABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private LDFMNPJEPAK DHEFFMPMCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private GEEADGMGHGF CDNDAKJCPHG;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x85B7CD0", Offset = "0x85B66D0", VA = "0x1885B7CD0", Slot = "6")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x85B7E40", Offset = "0x85B6840", VA = "0x1885B7E40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x85B7460", Offset = "0x85B5E60", VA = "0x1885B7460", Slot = "4")]
	public PEODKHABLII BAEJLNEPDAE(OBIDIGOJIIL PDPODIPFEJC)
	{
		return default(PEODKHABLII);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x85B7250", Offset = "0x85B5C50", VA = "0x1885B7250", Slot = "5")]
	public void AFCOEOPDIGI(Guid CFNOFGNKICA, Task DJBIHPNKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x85B8520", Offset = "0x85B6F20", VA = "0x1885B8520")]
	private void LOLEFINGPLK(HCCHCCGILAH IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x85B8B50", Offset = "0x85B7550", VA = "0x1885B8B50")]
	private void PPEEANGCEJM(APNHFNGFFLH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x85B88D0", Offset = "0x85B72D0", VA = "0x1885B88D0")]
	private void OMOMIFCLANH(APNHFNGFFLH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x85B7A90", Offset = "0x85B6490", VA = "0x1885B7A90")]
	private void CKEBCGDOCFE(APNHFNGFFLH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x85B8630", Offset = "0x85B7030", VA = "0x1885B8630")]
	private MKIOIHPBAPC NIDLHOIJIEA(OBIDIGOJIIL AGAELLMOCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x85B8140", Offset = "0x85B6B40", VA = "0x1885B8140")]
	private void IHKFABGIEFN(OBIDIGOJIIL AOLMLKPEBCG, MKIOIHPBAPC CNFJLDGBMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x85B8340", Offset = "0x85B6D40", VA = "0x1885B8340")]
	private bool JFIINKLPKIM(OBIDIGOJIIL AOLMLKPEBCG, MKIOIHPBAPC CNFJLDGBMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x85B7880", Offset = "0x85B6280", VA = "0x1885B7880")]
	private bool BBMMIGGPLEM(OBIDIGOJIIL OPHOAGKECMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x85B7EF0", Offset = "0x85B68F0", VA = "0x1885B7EF0")]
	private bool GJOMIPJHNDO(byte FDDOIFDLLNO, ExitGames.Client.Photon.Hashtable JEMDJIEKJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MPLLINLLJFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class AJFANALHCLK : AAPBPBAFHNC, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class ABKAEAILEAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public KCGEDCCFACD operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public AJFANALHCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public OBIDIGOJIIL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ABKAEAILEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x859ECD0", Offset = "0x859D6D0", VA = "0x18859ECD0")]
		internal object CLBKJCMNJCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x859ED40", Offset = "0x859D740", VA = "0x18859ED40")]
		internal object GIDIINOEBEM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PJKBJLDOJCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public AJFANALHCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public OBIDIGOJIIL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<MKIOIHPBAPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x85BC060", Offset = "0x85BAA60", VA = "0x1885BC060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x85BC700", Offset = "0x85BB100", VA = "0x1885BC700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class LMHLBGKOKBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public KCGEDCCFACD operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LMHLBGKOKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x85B2950", Offset = "0x85B1350", VA = "0x1885B2950")]
		internal object CIABCKPDIDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class CHIBDCNNELC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CHIBDCNNELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x85A27F0", Offset = "0x85A11F0", VA = "0x1885A27F0")]
		internal object KNCCIKHPDEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x85A2780", Offset = "0x85A1180", VA = "0x1885A2780")]
		internal object GBHMIGKGGMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x85A2710", Offset = "0x85A1110", VA = "0x1885A2710")]
		internal object FIJDKOOHFMC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LKPPKBBIEJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AJFANALHCLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private CHIBDCNNELC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private PEODKHABLII <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private MKIOIHPBAPC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private TaskAwaiter<(MKIOIHPBAPC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x85B2010", Offset = "0x85B0A10", VA = "0x1885B2010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x85B28E0", Offset = "0x85B12E0", VA = "0x1885B28E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private HIOIBLBFHFA HIDLGKOCDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private POOAGLCFPBF NMLIHFBGFLC;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x85A0180", Offset = "0x859EB80", VA = "0x1885A0180", Slot = "5")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x85A0560", Offset = "0x859EF60", VA = "0x1885A0560", Slot = "4")]
	[AsyncStateMachine(typeof(PJKBJLDOJCJ))]
	private Task<MKIOIHPBAPC> OBCCJAHKPOO(OBIDIGOJIIL AGAELLMOCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x85A0370", Offset = "0x859ED70", VA = "0x1885A0370")]
	private bool MOHAOFDHGMN(KCGEDCCFACD OFENPOIFLNA, [Out] MKIOIHPBAPC MGJNMKLFKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x85A0230", Offset = "0x859EC30", VA = "0x1885A0230")]
	[AsyncStateMachine(typeof(LKPPKBBIEJI))]
	private Task<MKIOIHPBAPC> LPHPCFNPGNE(OBIDIGOJIIL OHOKHLNBDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public AJFANALHCLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class PLHDKPDJHLN : IBDMDBGAGNJ, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct JHAFCDHOBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public LKFLNLIEOOH PDJMJFKFGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public long NMPJHNGJADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public Guid? DNLPJFMBGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public bool APHLONHMJGI;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct HCGAAHHNMFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<JKKKLGNDOCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public PLHDKPDJHLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<PFLGPOLCCPC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<JKKKLGNDOCB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x85A7A30", Offset = "0x85A6430", VA = "0x1885A7A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x85A8000", Offset = "0x85A6A00", VA = "0x1885A8000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class NFNCPHJEBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NFNCPHJEBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x85B97D0", Offset = "0x85B81D0", VA = "0x1885B97D0")]
		internal object PEEKDLHIFJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct PNJGKFOLEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<PFLGPOLCCPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public PLHDKPDJHLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private NFNCPHJEBIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private TaskAwaiter<PFLGPOLCCPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x85BD540", Offset = "0x85BBF40", VA = "0x1885BD540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB30", Offset = "0x85BC530", VA = "0x1885BDB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct CCBKIADBIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public AsyncTaskMethodBuilder<JKKKLGNDOCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public PLHDKPDJHLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public PFLGPOLCCPC roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<JHAFCDHOBPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x85A1450", Offset = "0x859FE50", VA = "0x1885A1450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x85A19C0", Offset = "0x85A03C0", VA = "0x1885A19C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class NHFJJBOMLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public PFLGPOLCCPC roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NHFJJBOMLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xEFEA00", Offset = "0xEFD400", VA = "0x180EFEA00")]
		internal bool IBNEFFDOFMF(BBAIIGBMJIM sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x85B9910", Offset = "0x85B8310", VA = "0x1885B9910")]
		internal object FMJPNGCFFLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x85B99D0", Offset = "0x85B83D0", VA = "0x1885B99D0")]
		internal object HFHJANGNDBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x85B9880", Offset = "0x85B8280", VA = "0x1885B9880")]
		internal object BEAOBOIHKIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class BMPHKDLGKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public NHFJJBOMLFF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BMPHKDLGKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x85A12A0", Offset = "0x859FCA0", VA = "0x1885A12A0")]
		internal object ECPJGFHODFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct LMLGNIAPEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder<JHAFCDHOBPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public PFLGPOLCCPC roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public PLHDKPDJHLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AKIBJNGPBHA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private BMPHKDLGKGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private TaskAwaiter<JHAFCDHOBPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter<FIDOJLMNKGC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x85B29C0", Offset = "0x85B13C0", VA = "0x1885B29C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x85B3950", Offset = "0x85B2350", VA = "0x1885B3950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class BOBOKJNBPAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BOBOKJNBPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x85A13A0", Offset = "0x859FDA0", VA = "0x1885A13A0")]
		internal object JIDAJFJCJEF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct PBEIKHMOMCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<JHAFCDHOBPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public BBAIIGBMJIM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public PLHDKPDJHLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public AKIBJNGPBHA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private BOBOKJNBPAE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private TaskAwaiter<KNOKFGDBNBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x85BA840", Offset = "0x85B9240", VA = "0x1885BA840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x85BAF00", Offset = "0x85B9900", VA = "0x1885BAF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NJLIBBEKNGN DHADAJLMNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private LGOEPKDHDBJ DAMCDMHKDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private IAGCFAJDJGB CGAKFHAOCIO;

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x85BC770", Offset = "0x85BB170", VA = "0x1885BC770", Slot = "5")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x85BCE10", Offset = "0x85BB810", VA = "0x1885BCE10", Slot = "4")]
	[AsyncStateMachine(typeof(HCGAAHHNMFL))]
	public Task<JKKKLGNDOCB> NMOIKMDFKCA(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, AKIBJNGPBHA JAOKMPOOJCM, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x85BC9D0", Offset = "0x85BB3D0", VA = "0x1885BC9D0")]
	[AsyncStateMachine(typeof(PNJGKFOLEEO))]
	private Task<PFLGPOLCCPC> FAKMPKCDHBF(AKIBJNGPBHA JAOKMPOOJCM, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x85BCB30", Offset = "0x85BB530", VA = "0x1885BCB30")]
	[AsyncStateMachine(typeof(CCBKIADBIMM))]
	private Task<JKKKLGNDOCB> GKHJMMMAPGI(AKIBJNGPBHA JAOKMPOOJCM, PFLGPOLCCPC NENGKGBFHCF, long HDLFBPMKPAB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x85BCCA0", Offset = "0x85BB6A0", VA = "0x1885BCCA0")]
	[AsyncStateMachine(typeof(LMLGNIAPEEH))]
	private Task<JHAFCDHOBPK> LHKJKLCEKNK(AKIBJNGPBHA JAOKMPOOJCM, PFLGPOLCCPC NENGKGBFHCF, long HDLFBPMKPAB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x85BC860", Offset = "0x85BB260", VA = "0x1885BC860")]
	[AsyncStateMachine(typeof(PBEIKHMOMCG))]
	private Task<JHAFCDHOBPK> EADEEPPGDGA(AKIBJNGPBHA IFEJMKFKEGP, BBAIIGBMJIM HGINIPFJDPN, long HDLFBPMKPAB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public PLHDKPDJHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class AHIHCHIKGFJ : BAGBLNJGMFA, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class NDBNOFMBCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NDBNOFMBCAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x85B90D0", Offset = "0x85B7AD0", VA = "0x1885B90D0")]
		internal object PJEFEPKMHMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct OHKHCNAPNLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AHIHCHIKGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public GIPKKFBMGMB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x85BA160", Offset = "0x85B8B60", VA = "0x1885BA160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x85BA770", Offset = "0x85B9170", VA = "0x1885BA770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct IIAHAKFEBJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public AHIHCHIKGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public GIPKKFBMGMB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private TaskAwaiter<MFLODBPBEKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x85AA110", Offset = "0x85A8B10", VA = "0x1885AA110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x85AA700", Offset = "0x85A9100", VA = "0x1885AA700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class FNMMAFGKILA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FNMMAFGKILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x85A5860", Offset = "0x85A4260", VA = "0x1885A5860")]
		internal object LOOLEDKHCHM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct CDDOJFGIHCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public OBIDIGOJIIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AHIHCHIKGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public GIPKKFBMGMB pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private KGPCDCOMIDE <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private KBFIECFHDAN <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter<MFLODBPBEKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x85A1A30", Offset = "0x85A0430", VA = "0x1885A1A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x85A2620", Offset = "0x85A1020", VA = "0x1885A2620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private KBAKMBAAPLC PFHOHNAJGKB;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private OIOAOOLIIFE MONAHCODJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x859FCD0", Offset = "0x859E6D0", VA = "0x18859FCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x859FA40", Offset = "0x859E440", VA = "0x18859FA40", Slot = "8")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x859FD90", Offset = "0x859E790", VA = "0x18859FD90", Slot = "4")]
	[AsyncStateMachine(typeof(OHKHCNAPNLO))]
	public Task<OBIDIGOJIIL> NHHAIJBJHJL(OBIDIGOJIIL OHOKHLNBDDB, GIPKKFBMGMB NAFHMMBAILG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x859FB80", Offset = "0x859E580", VA = "0x18859FB80", Slot = "5")]
	[AsyncStateMachine(typeof(IIAHAKFEBJL))]
	public Task<OBIDIGOJIIL> GMNKMODPGKJ(CancellationToken JKPNCAGHEDI, GIPKKFBMGMB NAFHMMBAILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x859FAD0", Offset = "0x859E4D0", VA = "0x18859FAD0", Slot = "6")]
	public JJLOAOIEJAJ DJEDAJHGJIE(CPEALFJADBF FOPLMKGNNJD, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x859FEF0", Offset = "0x859E8F0", VA = "0x18859FEF0", Slot = "7")]
	public JJLOAOIEJAJ OLENPPDNGLF(CPEALFJADBF FOPLMKGNNJD, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x85A0020", Offset = "0x859EA20", VA = "0x1885A0020")]
	[AsyncStateMachine(typeof(CDDOJFGIHCL))]
	private Task<OBIDIGOJIIL> PMODKJFFJKA(OBIDIGOJIIL OHOKHLNBDDB, GIPKKFBMGMB NAFHMMBAILG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8B90", Offset = "0x3AC7590", VA = "0x183AC8B90")]
	private static byte[] NBNFLLJBADM(OBIDIGOJIIL IJOJGNJMCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public AHIHCHIKGFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[UnityEngine.Scripting.Preserve]
internal sealed class PMNNMMHNOHC : HIOIBLBFHFA, PBPILMLJLCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private PEPJGPLIJNM FCGCKMEDFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private CLEBFCONPFG GAGBBFPHMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private GGJJCGFDIHD OPCKOCGHGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private LLJMALKPDCO JNKIODNFKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private LHGEHMBEHHE BJMKCJPJHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private NJLIBBEKNGN DHADAJLMNNE;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x85BD380", Offset = "0x85BBD80", VA = "0x1885BD380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static MKIOIHPBAPC PLABGECLEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x85BD370", Offset = "0x85BBD70", VA = "0x1885BD370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x85BD200", Offset = "0x85BBC00", VA = "0x1885BD200", Slot = "6")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x85BD3D0", Offset = "0x85BBDD0", VA = "0x1885BD3D0", Slot = "4")]
	public MKIOIHPBAPC MKOLLGAJBCD(GBDECDHLMJN BGKOOGGEMEH, KCGEDCCFACD CHMCGCPFKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x85BCF70", Offset = "0x85BB970", VA = "0x1885BCF70", Slot = "5")]
	public MKIOIHPBAPC CCBJGJGNEJC(GBDECDHLMJN DCMMAAEJIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x85BD1F0", Offset = "0x85BBBF0", VA = "0x1885BD1F0")]
	private static MKIOIHPBAPC CJKKGKKDDFP(FEOLABLGAAK CHGJGNFMEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public PMNNMMHNOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class JKLEPJFJKEE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x85AB710", Offset = "0x85AA110", VA = "0x1885AB710")]
	public JKLEPJFJKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x77385F0", Offset = "0x7736FF0", VA = "0x1877385F0")]
	public JKLEPJFJKEE(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[UnityEngine.Scripting.Preserve]
internal sealed class OLJEGFGHMIF : ODPAPHIFHIO, PBPILMLJLCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct AGDFJKFFENO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public BAMNMDPIDIE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private JBLIEDANKLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private EHHDGFGOCPA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter<MKIOIHPBAPC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x85C0090", Offset = "0x85BEA90", VA = "0x1885C0090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x85C0A60", Offset = "0x85BF460", VA = "0x1885C0A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OPGDAJFEAGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x85D8400", Offset = "0x85D6E00", VA = "0x1885D8400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x85D8B40", Offset = "0x85D7540", VA = "0x1885D8B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct OHLACIHJCLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x85D67C0", Offset = "0x85D51C0", VA = "0x1885D67C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x85D6CD0", Offset = "0x85D56D0", VA = "0x1885D6CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct KPDLBNDBAAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x85D0520", Offset = "0x85CEF20", VA = "0x1885D0520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x85D0CE0", Offset = "0x85CF6E0", VA = "0x1885D0CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct FBDDOHDFKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x85C6EF0", Offset = "0x85C58F0", VA = "0x1885C6EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x85C7090", Offset = "0x85C5A90", VA = "0x1885C7090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct LMEHDBKGFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x85D24E0", Offset = "0x85D0EE0", VA = "0x1885D24E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x85D2BF0", Offset = "0x85D15F0", VA = "0x1885D2BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct JMIFLBFBKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x85CE030", Offset = "0x85CCA30", VA = "0x1885CE030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x85CE4A0", Offset = "0x85CCEA0", VA = "0x1885CE4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct OJLBDPGLMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public OLJEGFGHMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public GCBBLAMCFIM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private JBLIEDANKLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x85D6D30", Offset = "0x85D5730", VA = "0x1885D6D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x85D72D0", Offset = "0x85D5CD0", VA = "0x1885D72D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private BAGBLNJGMFA EMNEDFGECOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private CLEBFCONPFG GAGBBFPHMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private LHGEHMBEHHE BJMKCJPJHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private CancellationTokenSource COMFFMIBPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Task FDEPOLONAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private TaskCompletionSource<int> IPDEKONBHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private int KDBDKPOMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private int KBLJEAEGCFN;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x85D7520", Offset = "0x85D5F20", VA = "0x1885D7520", Slot = "6")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x13E9640", Offset = "0x13E8040", VA = "0x1813E9640", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x85D76D0", Offset = "0x85D60D0", VA = "0x1885D76D0")]
	private void DIODGCJCJNE(float CFKJDJDNGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x85D7940", Offset = "0x85D6340", VA = "0x1885D7940", Slot = "4")]
	[AsyncStateMachine(typeof(AGDFJKFFENO))]
	public Task<MKIOIHPBAPC> FNGIAEPNMDG(BAMNMDPIDIE HGDFIMDKHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x85D7DF0", Offset = "0x85D67F0", VA = "0x1885D7DF0", Slot = "5")]
	[AsyncStateMachine(typeof(OPGDAJFEAGK))]
	public Task IMPKJALLONA([Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x13E9640", Offset = "0x13E8040", VA = "0x1813E9640")]
	public void HMOIMCBJGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x85D81D0", Offset = "0x85D6BD0", VA = "0x1885D81D0")]
	private EHHDGFGOCPA PEEIFAGLOLC(BAMNMDPIDIE HGDFIMDKHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x85D7330", Offset = "0x85D5D30", VA = "0x1885D7330")]
	[AsyncStateMachine(typeof(OHLACIHJCLN))]
	private Task BHAAGDICKBI(CancellationToken IFGGPDNONLM, int HPCPGOCBOHJ, IIOJHPILAFO EONHKBDBPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x85D7A70", Offset = "0x85D6470", VA = "0x1885D7A70")]
	[AsyncStateMachine(typeof(KPDLBNDBAAB))]
	private Task GDFCKDLIIKN(CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x85D7EE0", Offset = "0x85D68E0", VA = "0x1885D7EE0")]
	[AsyncStateMachine(typeof(FBDDOHDFKNI))]
	private Task JHMMEONLGED([Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x85D80E0", Offset = "0x85D6AE0", VA = "0x1885D80E0")]
	[AsyncStateMachine(typeof(LMEHDBKGFEC))]
	private Task MAMDLBKHFDN(CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x85D7420", Offset = "0x85D5E20", VA = "0x1885D7420")]
	[AsyncStateMachine(typeof(JMIFLBFBKAK))]
	private Task COHBOEEIKKJ(CancellationToken BLLPIKJBGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x85D77B0", Offset = "0x85D61B0", VA = "0x1885D77B0")]
	private Task FFDCBFEECJO(GCBBLAMCFIM JABFDEBGCIN, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x85D7FD0", Offset = "0x85D69D0", VA = "0x1885D7FD0")]
	[AsyncStateMachine(typeof(OJLBDPGLMDD))]
	private Task LKOHGKAGKJK(GCBBLAMCFIM JABFDEBGCIN, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x85D7B70", Offset = "0x85D6570", VA = "0x1885D7B70")]
	private bool HFKINFEGOJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OLJEGFGHMIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[UnityEngine.Scripting.Preserve]
internal class HPJICLNEBNJ : GGJJCGFDIHD, PBPILMLJLCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct GMFLJJKHLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public HPJICLNEBNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private JBLIEDANKLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x85C99C0", Offset = "0x85C83C0", VA = "0x1885C99C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x85C9F80", Offset = "0x85C8980", VA = "0x1885C9F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private OBLLMGJFLEG KNNGAINLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private HIOIBLBFHFA HIDLGKOCDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	private BAGBLNJGMFA EMNEDFGECOP;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x85CB6C0", Offset = "0x85CA0C0", VA = "0x1885CB6C0", Slot = "6")]
	public void DBILOAODCDE(HKFGPGHMLEK DLDEJAGLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x85CB9A0", Offset = "0x85CA3A0", VA = "0x1885CB9A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x85CB5C0", Offset = "0x85C9FC0", VA = "0x1885CB5C0", Slot = "5")]
	[AsyncStateMachine(typeof(GMFLJJKHLEJ))]
	public Task CFJKOKNJHNN(string KJHMBICDBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x85CBB30", Offset = "0x85CA530", VA = "0x1885CBB30", Slot = "4")]
	public MKIOIHPBAPC HFKINFEGOJO(GBDECDHLMJN BGKOOGGEMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x85CB9F0", Offset = "0x85CA3F0", VA = "0x1885CB9F0")]
	private PHDHOEPGIJE FBNGDBKDLMG(string KJHMBICDBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public HPJICLNEBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class IFBFOOJPHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x85CBB90", Offset = "0x85CA590", VA = "0x1885CBB90")]
	public static void DDAPHDJEPFP(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x85CBDD0", Offset = "0x85CA7D0", VA = "0x1885CBDD0")]
	internal static void FNBPLIJJAHL(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x85CBF30", Offset = "0x85CA930", VA = "0x1885CBF30")]
	internal static void KBMHJIOAHEF(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x85CC010", Offset = "0x85CAA10", VA = "0x1885CC010")]
	internal static void LONHOIACFKJ(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3500", Offset = "0x3AA1F00", VA = "0x183AA3500")]
	private static void KGLOAFCELKP<Interface, Impl, Interface>(MHGNCMHMEKD DJGDNAKMFCE) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class BPMFFJANDOJ : BPIAFPPOBPG<OBIDIGOJIIL>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class APHNKPFKJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public OBIDIGOJIIL message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public APHNKPFKJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x85C0AD0", Offset = "0x85BF4D0", VA = "0x1885C0AD0")]
		internal object IMIEMAFBCCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly BPMFFJANDOJ FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x85C1D30", Offset = "0x85C0730", VA = "0x1885C1D30")]
	public ExitGames.Client.Photon.Hashtable PGPOMLMDCHO(OBIDIGOJIIL IJOJGNJMCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x85C18C0", Offset = "0x85C02C0", VA = "0x1885C18C0", Slot = "5")]
	protected override void HDJMKGOBJDB(OBIDIGOJIIL IJOJGNJMCGP, IDictionary<object, object> HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x85C1B00", Offset = "0x85C0500", VA = "0x1885C1B00", Slot = "6")]
	public override OBIDIGOJIIL PGEPBAPICDN(IDictionary<object, object> HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x85C19F0", Offset = "0x85C03F0", VA = "0x1885C19F0")]
	private static void NLLEOCMFOCP(string ECPGINANOKO, OBIDIGOJIIL IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x85C1E50", Offset = "0x85C0850", VA = "0x1885C1E50")]
	public BPMFFJANDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x85C1610", Offset = "0x85C0010", VA = "0x1885C1610")]
	[CompilerGenerated]
	internal static string BMOAEDNGKLH(JKKKLGNDOCB MGDBGDNLMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class MFPJKGKCMNK
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static MKIOIHPBAPC PLABGECLEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x85D34D0", Offset = "0x85D1ED0", VA = "0x1885D34D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x85D34B0", Offset = "0x85D1EB0", VA = "0x1885D34B0")]
	public static bool EEDFIEAIBDI(this MKIOIHPBAPC CNFJLDGBMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x85D3450", Offset = "0x85D1E50", VA = "0x1885D3450")]
	public static MKIOIHPBAPC CJKKGKKDDFP(FEOLABLGAAK EPJIFGCCNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x85D3530", Offset = "0x85D1F30", VA = "0x1885D3530")]
	public static MKIOIHPBAPC GPFEHGANODE(IEnumerable<MKIOIHPBAPC> PLGIOHLBNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x85D3720", Offset = "0x85D2120", VA = "0x1885D3720")]
	public static string IPNIDCGOPKB(this MKIOIHPBAPC MGJNMKLFKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class GAOJGDJBHOO : IGLHJOALLHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public delegate MKIOIHPBAPC HCEFACDICAD([NotNull] GBDECDHLMJN FKLJNCFBHIA);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class NNMJEEFNIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public GBDECDHLMJN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NNMJEEFNIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x16A9D80", Offset = "0x16A8780", VA = "0x1816A9D80")]
		internal MKIOIHPBAPC PIFBNIMMGKP(HCEFACDICAD v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	protected readonly HashSet<HCEFACDICAD> AHLKBKCAGAB;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x85C7FF0", Offset = "0x85C69F0", VA = "0x1885C7FF0", Slot = "4")]
	public void COAHAPNNFCP(HCEFACDICAD LCFCCHFFBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x85C8330", Offset = "0x85C6D30", VA = "0x1885C8330", Slot = "5")]
	public void KBDECIMFNEE(HCEFACDICAD LCFCCHFFBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x85C8050", Offset = "0x85C6A50", VA = "0x1885C8050", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x85C80A0", Offset = "0x85C6AA0", VA = "0x1885C80A0")]
	protected MKIOIHPBAPC FMKPLPHMBJK(GBDECDHLMJN DCMMAAEJIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x85C8390", Offset = "0x85C6D90", VA = "0x1885C8390")]
	protected GAOJGDJBHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class NIBELAGCEGM : GAOJGDJBHOO, PEPJGPLIJNM, IGLHJOALLHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class CNEAHGPEHKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public MKIOIHPBAPC result;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CNEAHGPEHKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x85C3CF0", Offset = "0x85C26F0", VA = "0x1885C3CF0")]
		internal object NBFGNNLBMOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x85C3E60", Offset = "0x85C2860", VA = "0x1885C3E60")]
	[UnityEngine.Scripting.Preserve]
	public NIBELAGCEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x85D6190", Offset = "0x85D4B90", VA = "0x1885D6190", Slot = "8")]
	public MKIOIHPBAPC OAFEFKBCPLE(GBDECDHLMJN DCMMAAEJIEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class COBBAAJNFEL : GAOJGDJBHOO, OBLLMGJFLEG, IGLHJOALLHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class JPKNODADEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public MKIOIHPBAPC result;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JPKNODADEJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x85CE500", Offset = "0x85CCF00", VA = "0x1885CE500")]
		internal object MOCGNNJCMCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x85C3E60", Offset = "0x85C2860", VA = "0x1885C3E60")]
	[UnityEngine.Scripting.Preserve]
	public COBBAAJNFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x85C3D50", Offset = "0x85C2750", VA = "0x1885C3D50", Slot = "8")]
	public MKIOIHPBAPC HFKINFEGOJO(GBDECDHLMJN IKJHHAOIKGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal static class NPFLEJPDBGI
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class HDKLENAJAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public JBLIEDANKLD<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HDKLENAJAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x85CA630", Offset = "0x85C9030", VA = "0x1885CA630")]
		internal object MLMDJBMOHNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x85D6490", Offset = "0x85D4E90", VA = "0x1885D6490")]
	public static JBLIEDANKLD<string> ONHJAFFAHBF(COJJKFBGGKB PMPMPCJHKKF, [Optional] string JEGOPGAILHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x85D63D0", Offset = "0x85D4DD0", VA = "0x1885D63D0")]
	public static void MAKBELEEOBL(JBLIEDANKLD<string> JNHNJKFGOJB, COJJKFBGGKB PMPMPCJHKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x85D6310", Offset = "0x85D4D10", VA = "0x1885D6310")]
	public static string CFABHOIMGOH(OBIDIGOJIIL AGAELLMOCGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class BPIIAFANOGE
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x85C1600", Offset = "0x85C0000", VA = "0x1885C1600")]
	public static void MDIIGHDGLPL(this ICKNPKBJODA JEJFACEGMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x85C15F0", Offset = "0x85BFFF0", VA = "0x1885C15F0")]
	public static void KHKHOMFONJH(this ICKNPKBJODA JEJFACEGMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x85C14D0", Offset = "0x85BFED0", VA = "0x1885C14D0")]
	private static void BHAPFMBCDNH(this ICKNPKBJODA JEJFACEGMCJ, bool MBBPCFCIONE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class FIDIKEDIEMG : AHIDOPECKNN, OHJGNBHMELG, PEKPECOOHHK, OJFODEFOOCG
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[DefaultMember("Item")]
	private class FBGHKKGKDJO : HCCHCCGILAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly byte PGBNNEFOMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly int GAMOJFHOMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly object HLBPLIKPFPJ;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte GELPCFHKOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int DIKGDMMMELA
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA627B0", Offset = "0xA611B0", VA = "0x180A627B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object CHFABLEDFEN
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object OIPJADEMDCE
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x85C70F0", Offset = "0x85C5AF0", VA = "0x1885C70F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x773FCD0", Offset = "0x773E6D0", VA = "0x18773FCD0")]
		public FBGHKKGKDJO(byte PGBNNEFOMAE, int GAMOJFHOMGC, object HLBPLIKPFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x85C7140", Offset = "0x85C5B40", VA = "0x1885C7140", Slot = "8")]
		public bool EHEIJGNBGFA(byte KJNEHANBOBO, [Out] object PCDAHJCDHHF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly OHJGNBHMELG EMHNCMOLDBK;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public GBDECDHLMJN IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x85C79D0", Offset = "0x85C63D0", VA = "0x1885C79D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int LDFEKHOEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x85C7DB0", Offset = "0x85C67B0", VA = "0x1885C7DB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int PMIODMHHDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x85C7CA0", Offset = "0x85C66A0", VA = "0x1885C7CA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public GBDECDHLMJN JGEBLPFAMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x85C7760", Offset = "0x85C6160", VA = "0x1885C7760", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int AADKJDGOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA62010", Offset = "0xA60A10", VA = "0x180A62010", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string EGEMLGEHLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x85C7700", Offset = "0x85C6100", VA = "0x1885C7700", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> JGLNHDAOBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x85C7CF0", Offset = "0x85C66F0", VA = "0x1885C7CF0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> EKDELKNBGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<HCCHCCGILAH> PKPBOODOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x85C7E00", Offset = "0x85C6800", VA = "0x1885C7E00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x85C75B0", Offset = "0x85C5FB0", VA = "0x1885C75B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> FJEDEPJAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<GBDECDHLMJN> JIDLHFGGFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action PMBABKOOJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x85C7510", Offset = "0x85C5F10", VA = "0x1885C7510", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x85C7660", Offset = "0x85C6060", VA = "0x1885C7660", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x85C7890", Offset = "0x85C6290", VA = "0x1885C7890", Slot = "19")]
	public void FLGHPFFDPPM(string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xDAE760", Offset = "0xDAD160", VA = "0x180DAE760")]
	public FIDIKEDIEMG(OHJGNBHMELG EMHNCMOLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x85C7B50", Offset = "0x85C6550", VA = "0x1885C7B50", Slot = "8")]
	public bool IPNAMOAAKJD(byte FDDOIFDLLNO, object AHJCOCMFHID, AIJLKOBFKFM CMJDPJIOEOH, JOJLAKAOABL PPFPKPFAHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x85C7470", Offset = "0x85C5E70", VA = "0x1885C7470", Slot = "20")]
	public GBDECDHLMJN AJIEBPGPDHN(int KJCCMAJJDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x85C77B0", Offset = "0x85C61B0", VA = "0x1885C77B0", Slot = "21")]
	public GBDECDHLMJN DPMEAONPLEO(int LIEFHLCIOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x85C78F0", Offset = "0x85C62F0", VA = "0x1885C78F0", Slot = "22")]
	public GBDECDHLMJN FNCKIJJKJPD(int KJCCMAJJDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x85C7A20", Offset = "0x85C6420", VA = "0x1885C7A20", Slot = "23")]
	public IReadOnlyList<GBDECDHLMJN> HACFFNGHAME(bool JPLKHIANGNK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x85C7C60", Offset = "0x85C6660", VA = "0x1885C7C60", Slot = "24")]
	public IReadOnlyList<GBDECDHLMJN> KKHOBEAFHMC(bool JPLKHIANGNK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "25")]
	public bool BEBNMLALAHL(GBDECDHLMJN MAMJPGLPJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "28")]
	public void ELJLDMBGDGJ(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "29")]
	public void OCHHEDAJKCC(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "30")]
	public void CAGLEGDDCHL(object BECBHDDLOHA, bool EIOLKALMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x85C7B00", Offset = "0x85C6500", VA = "0x1885C7B00", Slot = "31")]
	public IDisposable IJNKAKHIJCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "32")]
	private bool AEBCHHMACOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "33")]
	public void MEFAADNHDKK(StringBuilder MLDFCHHLDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xFFA7F0", Offset = "0xFF91F0", VA = "0x180FFA7F0", Slot = "34")]
	public bool CLAJHGBOFOI(bool HIPALJBMCHM, [Out] string OLIGKIPGKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xF70250", Offset = "0xF6EC50", VA = "0x180F70250", Slot = "37")]
	public void MFAHBABEGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct APNHFNGFFLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly IDictionary<object, object> JEMDJIEKJFA;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	public APNHFNGFFLH(IDictionary<object, object> JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x85C0F60", Offset = "0x85BF960", VA = "0x1885C0F60")]
	public bool IAFMAPHBMKC([Out] OBIDIGOJIIL IJOJGNJMCGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x85C1100", Offset = "0x85BFB00", VA = "0x1885C1100")]
	public Guid MFKNKNODEPL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x85C0E30", Offset = "0x85BF830", VA = "0x1885C0E30")]
	public MKIOIHPBAPC FOIIIPHCGDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x85C1010", Offset = "0x85BFA10", VA = "0x1885C1010")]
	public static ExitGames.Client.Photon.Hashtable JEBOFNEMEAN(OBIDIGOJIIL IJOJGNJMCGP, MKIOIHPBAPC CNFJLDGBMJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal static class HHNKKHOFOFK
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x85CA980", Offset = "0x85C9380", VA = "0x1885CA980")]
	public static bool OBFAEBCGHPP(this AKIBJNGPBHA HDBNMLIMHPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct DNEBAKJCLGP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct CMKNHFFCKCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public DNEBAKJCLGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x85C3730", Offset = "0x85C2130", VA = "0x1885C3730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x85C3910", Offset = "0x85C2310", VA = "0x1885C3910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly CancellationTokenSource IFHBDAKCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private Task HAAEKADIBMM;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool HBILGBNKLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x85C5770", Offset = "0x85C4170", VA = "0x1885C5770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x85C57A0", Offset = "0x85C41A0", VA = "0x1885C57A0")]
	public DNEBAKJCLGP(CancellationToken JKPNCAGHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x85C5660", Offset = "0x85C4060", VA = "0x1885C5660")]
	[AsyncStateMachine(typeof(CMKNHFFCKCC))]
	public Task FKDDCOGDBPF(Func<CancellationToken, List<Task>> IHDKBJMENGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x85C5610", Offset = "0x85C4010", VA = "0x1885C5610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public readonly struct ODBFDHFNLPH<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct KHHDFJMFMML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<GODECPCJOOD<TData>, GJIFJLKDAGC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public ODBFDHFNLPH<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter<KAFLOHEKGBO<GODECPCJOOD<TData>, GJIFJLKDAGC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x51C2E10", Offset = "0x51C1810", VA = "0x1851C2E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x46BE7B0", Offset = "0x46BD1B0", VA = "0x1846BE7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly NKCECGKOLIK<TGetDataArg, TData> JIMKFPLDKKF;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	internal ODBFDHFNLPH(NKCECGKOLIK<TGetDataArg, TData> BFPFMKIIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5658230", Offset = "0x5656C30", VA = "0x185658230")]
	[AsyncStateMachine(typeof(ODBFDHFNLPH<, >.KHHDFJMFMML))]
	public Task<KAFLOHEKGBO<GODECPCJOOD<TData>, GJIFJLKDAGC>> EMKFEFDOBLB(TGetDataArg EFPDHJCEEGP, string JHNCJKMJBJP, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class BFJGONDPELH
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2A30", Offset = "0x2FF1430", VA = "0x182FF2A30")]
	public static ODBFDHFNLPH<TGetDataArg, TData> FMDOFBCLPJB<TGetDataArg, TData>(NKCECGKOLIK<TGetDataArg, TData> BFPFMKIIKBG)
	{
		return default(ODBFDHFNLPH<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct FFMJGFGHNFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly int GELPCFHKOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly int? CBNMLAPNOGC;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x52685B0", Offset = "0x5266FB0", VA = "0x1852685B0")]
	public FFMJGFGHNFM(int PGBNNEFOMAE, [Optional] int? EJEBMFJPDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x85C7190", Offset = "0x85C5B90", VA = "0x1885C7190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface GKMPBMMGCOD<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHHFDOJEHEO();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKMPBMMGCOD<T> GANHFMEMIFA(string DJGLMHAPDBP);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKMPBMMGCOD<T> PGLDPMEDNEC(GBJAJALGEON<T> FKHPJODNDJM);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GKMPBMMGCOD<T> FMNBEJIIDMK(int IPOOJEEDJGK);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKMPBMMGCOD<T> LJHHIOCPFIL(int IPOOJEEDJGK, AIEPALKFCMH<T> ILAKGJFCFFG);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface LMPNAOLEGDD
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKMPBMMGCOD<T> KNHPNGHCPHG<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MOAEBAJJLGP GJPKHDMBJNK(Exception AGKNBEAOFAM);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FFMJGFGHNFM MLPEINKMKKH(Exception AGKNBEAOFAM);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate string GBJAJALGEON<in T>(T AGKNBEAOFAM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate int AIEPALKFCMH<in T>(T AGKNBEAOFAM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class ABMEOKICGCL : LMPNAOLEGDD
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate string OBOEBKEIAMG(Exception AGKNBEAOFAM);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate int AHBCMMIPEAE(Exception AGKNBEAOFAM);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class EMPNDFEKDAD<T> : GKMPBMMGCOD<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class MBJPMJNLLKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public MBJPMJNLLKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			internal string FBEDFAMMAEG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class MDDPOLFMKAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public GBJAJALGEON<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public MDDPOLFMKAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x5475620", Offset = "0x5474020", VA = "0x185475620")]
			internal string PJGEMOMJODM(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class PKBMJJIHBOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public AIEPALKFCMH<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public PKBMJJIHBOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x5475620", Offset = "0x5474020", VA = "0x185475620")]
			internal int DPOGNMMEDEB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly ABMEOKICGCL HOEJKEDGJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly Type DHJJFCNBAEN;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x46B93B0", Offset = "0x46B7DB0", VA = "0x1846B93B0")]
		internal EMPNDFEKDAD(ABMEOKICGCL HOEJKEDGJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x46B9160", Offset = "0x46B7B60", VA = "0x1846B9160", Slot = "4")]
		public void JHHFDOJEHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x46B9060", Offset = "0x46B7A60", VA = "0x1846B9060", Slot = "5")]
		public GKMPBMMGCOD<T> GANHFMEMIFA(string DJGLMHAPDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x46B92B0", Offset = "0x46B7CB0", VA = "0x1846B92B0", Slot = "6")]
		public GKMPBMMGCOD<T> PGLDPMEDNEC(GBJAJALGEON<T> FKHPJODNDJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x46B9020", Offset = "0x46B7A20", VA = "0x1846B9020", Slot = "7")]
		public GKMPBMMGCOD<T> FMNBEJIIDMK(int IPOOJEEDJGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x46B9190", Offset = "0x46B7B90", VA = "0x1846B9190", Slot = "8")]
		public GKMPBMMGCOD<T> LJHHIOCPFIL(int IPOOJEEDJGK, AIEPALKFCMH<T> ILAKGJFCFFG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class DHHFHFGNEOO<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private bool AMOFAALBPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly List<Type> LBOINLCFPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly Dictionary<Type, TVal> DMCELOOPCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly Dictionary<Type, int> PCAOJKIFLGA;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> HBIPPGJAIHP
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x6AF0A60", Offset = "0x6AEF460", VA = "0x186AF0A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0D30", Offset = "0x6AEF730", VA = "0x186AF0D30")]
		public DHHFHFGNEOO(Dictionary<Type, int> PCAOJKIFLGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0B50", Offset = "0x6AEF550", VA = "0x186AF0B50")]
		public void PBDMKLNODMP(Type KJNEHANBOBO, TVal KPILPFEAJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0830", Offset = "0x6AEF230", VA = "0x186AF0830")]
		public bool ABHJGNDOOHI(Type DHJJFCNBAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0B10", Offset = "0x6AEF510", VA = "0x186AF0B10")]
		public bool ONLIFFPIAIK(TVal PCDAHJCDHHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4268420", Offset = "0x4266E20", VA = "0x184268420")]
		public TVal IBPMNADNGOO(Type HHCAOFMCNLG)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0870", Offset = "0x6AEF270", VA = "0x186AF0870")]
		[CompilerGenerated]
		private int DEAANGJCMAP(Type EBPNNPIILDF, Type NKKAENNAHJI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class NGLKOPKCFGI : IEnumerable<FFMJGFGHNFM>, IEnumerable, IEnumerator<FFMJGFGHNFM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private FFMJGFGHNFM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public ABMEOKICGCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private IEnumerator<FFMJGFGHNFM> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private FFMJGFGHNFM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x4756060", Offset = "0x4754A60", VA = "0x184756060", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FFMJGFGHNFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x85D5090", Offset = "0x85D3A90", VA = "0x1885D5090", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public NGLKOPKCFGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x85D50E0", Offset = "0x85D3AE0", VA = "0x1885D50E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x85D4A80", Offset = "0x85D3480", VA = "0x1885D4A80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x85D4A30", Offset = "0x85D3430", VA = "0x1885D4A30")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x85D4F30", Offset = "0x85D3930", VA = "0x1885D4F30")]
		private void NODCBNAELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x85D5040", Offset = "0x85D3A40", VA = "0x1885D5040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x85D4F80", Offset = "0x85D3980", VA = "0x1885D4F80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FFMJGFGHNFM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x85D4F80", Offset = "0x85D3980", VA = "0x1885D4F80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private static readonly FFMJGFGHNFM CHHNDJGLKEA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private static readonly Dictionary<Type, int> PMCMEMCMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly HashSet<Type> HDIJFDPGPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly DHHFHFGNEOO<int> GBHIPJCPHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly DHHFHFGNEOO<AHBCMMIPEAE> DBKBHKFBMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly DHHFHFGNEOO<OBOEBKEIAMG> BBCJJKGIBJK;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x85BF3A0", Offset = "0x85BDDA0", VA = "0x1885BF3A0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void JGOIPALGEOO(MHGNCMHMEKD OHEABDJLGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x85BF850", Offset = "0x85BE250", VA = "0x1885BF850")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABMEOKICGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0", Slot = "4")]
	public GKMPBMMGCOD<T> KNHPNGHCPHG<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x85BEB40", Offset = "0x85BD540", VA = "0x1885BEB40", Slot = "5")]
	public MOAEBAJJLGP GJPKHDMBJNK(Exception AGKNBEAOFAM)
	{
		return default(MOAEBAJJLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x85BF590", Offset = "0x85BDF90", VA = "0x1885BF590", Slot = "6")]
	public FFMJGFGHNFM MLPEINKMKKH(Exception? AGKNBEAOFAM)
	{
		return default(FFMJGFGHNFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x85BF410", Offset = "0x85BDE10", VA = "0x1885BF410", Slot = "7")]
	[IteratorStateMachine(typeof(NGLKOPKCFGI))]
	public IEnumerable<FFMJGFGHNFM> KLIHJCBKIPI(Exception AGKNBEAOFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x85BEBD0", Offset = "0x85BD5D0", VA = "0x1885BEBD0", Slot = "8")]
	public string HJECMLMMJKD(Exception? AGKNBEAOFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x85BE840", Offset = "0x85BD240", VA = "0x1885BE840")]
	private string GIDPDHEICAN(AggregateException KBOMNHICHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x85BED20", Offset = "0x85BD720", VA = "0x1885BED20")]
	private void IELDHLBKIIM(Type DHJJFCNBAEN, int IPOOJEEDJGK, AHBCMMIPEAE? NFILJEOBKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x85BE470", Offset = "0x85BCE70", VA = "0x1885BE470")]
	private void AHPEDOBOEJO(Type DHJJFCNBAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x85BF0D0", Offset = "0x85BDAD0", VA = "0x1885BF0D0")]
	private void IJBAFCDHPMO(Type DHJJFCNBAEN, OBOEBKEIAMG NDEPOCMLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x85BE6C0", Offset = "0x85BD0C0", VA = "0x1885BE6C0")]
	private static int GGMCILALPPN(Type DHJJFCNBAEN, Dictionary<Type, int> PCAOJKIFLGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2FFFCE0", Offset = "0x2FFE6E0", VA = "0x182FFFCE0")]
	private static bool INLGPBFJNIB<TVal>(DHHFHFGNEOO<TVal> OKEIIBNBBOL, Type DHJJFCNBAEN, [Out] TVal PCDAHJCDHHF) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x85BF4B0", Offset = "0x85BDEB0", VA = "0x1885BF4B0")]
	[CompilerGenerated]
	internal static int LJDDFHEBGON(Type MOFGEBEGJKD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct MOAEBAJJLGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public readonly FFMJGFGHNFM DNBLHKMCPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public readonly string CNKMKHPLICG;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x85D4220", Offset = "0x85D2C20", VA = "0x1885D4220")]
	public MOAEBAJJLGP(string BEGMOMCBBFP, FFMJGFGHNFM IPOOJEEDJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x85D4180", Offset = "0x85D2B80", VA = "0x1885D4180")]
	public string HDJOPMHHNMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class EGNOIGEDNKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private readonly IEANCGLMOMK LKKLKJDJBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private string HDNFCKACDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private long? BJECPJPNJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private long? EMADECELHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private long? FECDHGJKIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private string PLFBHJJCBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private NBLBPMKGJIE CBGIDKCPLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? ICMLOBPNOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private bool PIIHHNMOIAF;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string LLGFIJFNPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long KKHAHAFPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x85C6200", Offset = "0x85C4C00", VA = "0x1885C6200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long DGHFENOEEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x85C5EF0", Offset = "0x85C48F0", VA = "0x1885C5EF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long PEKOEDBBFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x85C5E90", Offset = "0x85C4890", VA = "0x1885C5E90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string FPPPPGKBGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x85C5D60", Offset = "0x85C4760", VA = "0x1885C5D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NBLBPMKGJIE AEPPHKPCOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xA676C0", Offset = "0xA660C0", VA = "0x180A676C0")]
		get
		{
			return default(NBLBPMKGJIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x85C5DA0", Offset = "0x85C47A0", VA = "0x1885C5DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long JDOLJFMOLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x85C5F50", Offset = "0x85C4950", VA = "0x1885C5F50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x85C6B80", Offset = "0x85C5580", VA = "0x1885C6B80")]
	[UnityEngine.Scripting.Preserve]
	public EGNOIGEDNKF([CNHMBDDCGKB(null)] IEANCGLMOMK LKKLKJDJBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x85C5FB0", Offset = "0x85C49B0", VA = "0x1885C5FB0")]
	private void JLJGOPPOEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x85C65D0", Offset = "0x85C4FD0", VA = "0x1885C65D0")]
	public void MMAALFLJDIE(long FHOIPEIAACP, long HDLFBPMKPAB, [Optional] long? LOMEDBPBLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x85C6A60", Offset = "0x85C5460", VA = "0x1885C6A60")]
	public void NJHKMINBEDM(long LOMEDBPBLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x85C6B00", Offset = "0x85C5500", VA = "0x1885C6B00")]
	public void PKBEMADDGNL(string BCEJMNDKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x85C6260", Offset = "0x85C4C60", VA = "0x1885C6260")]
	public void MEENGEIGEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class JJLOAOIEJAJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct CFICKJCBINP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public OBIDIGOJIIL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public JJLOAOIEJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<OIOAOOLIIFE.PMCEBMLAJDB<OBIDIGOJIIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x85C3180", Offset = "0x85C1B80", VA = "0x1885C3180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x85C36C0", Offset = "0x85C20C0", VA = "0x1885C36C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct KMMBCDGDLOC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class EKOFCDEGJCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public OBIDIGOJIIL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EKOFCDEGJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x85C6E10", Offset = "0x85C5810", VA = "0x1885C6E10")]
		internal OBIDIGOJIIL AJEMJALBMAO(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct LCBIFILIPLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder<OIOAOOLIIFE.PMCEBMLAJDB<OBIDIGOJIIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public OBIDIGOJIIL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public JJLOAOIEJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private KGPCDCOMIDE <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private TaskAwaiter<OIOAOOLIIFE.PMCEBMLAJDB<OBIDIGOJIIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x85D0D40", Offset = "0x85CF740", VA = "0x1885D0D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x85D1350", Offset = "0x85CFD50", VA = "0x1885D1350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct MFPPCIMBLAI<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public JJLOAOIEJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x547BE40", Offset = "0x547A840", VA = "0x18547BE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x46BE7B0", Offset = "0x46BD1B0", VA = "0x1846BE7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct DOFAFALAMID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public JJLOAOIEJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x85C58D0", Offset = "0x85C42D0", VA = "0x1885C58D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x85C5BB0", Offset = "0x85C45B0", VA = "0x1885C5BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class KIHAKKJKMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KIHAKKJKMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x85D0400", Offset = "0x85CEE00", VA = "0x1885D0400")]
		internal object HHNOOONNEMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x85D0460", Offset = "0x85CEE60", VA = "0x1885D0460")]
		internal bool OEGFBENIOPH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class BIPOKEHAJEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BIPOKEHAJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x85C13B0", Offset = "0x85BFDB0", VA = "0x1885C13B0")]
		internal object BCPEIDGLCPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class ABHCIBBAOAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ABHCIBBAOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x85BE400", Offset = "0x85BCE00", VA = "0x1885BE400")]
		internal object LBBLEAMLEOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class HMOHGKAKAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HMOHGKAKAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x85CB550", Offset = "0x85C9F50", VA = "0x1885CB550")]
		internal object OGPFPMHHFJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class PFNPBDNBPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public JJLOAOIEJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PFNPBDNBPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x85DA100", Offset = "0x85D8B00", VA = "0x1885DA100")]
		internal object IMIEMAFBCCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly Guid GOOCNDODOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public readonly CPEALFJADBF PKCFNJINFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private readonly OIOAOOLIIFE AJONJCMHHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly PEKPECOOHHK JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private readonly OJFODEFOOCG JCGIFNHHBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private bool ALNAHJDFAMH;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x85CDE00", Offset = "0x85CC800", VA = "0x1885CDE00")]
	public JJLOAOIEJAJ(CPEALFJADBF GNLEPFMJLKI, OIOAOOLIIFE AJONJCMHHAH, PEKPECOOHHK JEJFACEGMCJ, OJFODEFOOCG JCGIFNHHBEM, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x85CCF10", Offset = "0x85CB910", VA = "0x1885CCF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x85CD480", Offset = "0x85CBE80", VA = "0x1885CD480")]
	public void JHFFEBOGFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x85CCE50", Offset = "0x85CB850", VA = "0x1885CCE50")]
	public void DNNGGHIBFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x85CCC10", Offset = "0x85CB610", VA = "0x1885CCC10")]
	public void AJIGJKNOECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x85CCF20", Offset = "0x85CB920", VA = "0x1885CCF20")]
	[AsyncStateMachine(typeof(CFICKJCBINP))]
	internal Task<OBIDIGOJIIL> ELIMHHPNPNK(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, OBIDIGOJIIL AGAELLMOCGI, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8B90", Offset = "0x3AC7590", VA = "0x183AC8B90")]
	private static byte[] OBCPADJKIJE<T>(T IJOJGNJMCGP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8520", Offset = "0x3AC6F20", VA = "0x183AC8520")]
	private static T DGKCCELMPAG<T>(MessageParser<T> MJIHIFGLAJO, byte[] IJOJGNJMCGP, T LMMABDJIADL) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x85CD2C0", Offset = "0x85CBCC0", VA = "0x1885CD2C0")]
	[AsyncStateMachine(typeof(LCBIFILIPLD))]
	private Task<OIOAOOLIIFE.PMCEBMLAJDB<OBIDIGOJIIL>> JALKOJLHPBI(OBIDIGOJIIL AGAELLMOCGI, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8910", Offset = "0x3AC7310", VA = "0x183AC8910")]
	[AsyncStateMachine(typeof(MFPPCIMBLAI<>))]
	internal Task<T> MLDHJOAKHGN<T>(CancellationToken IFGGPDNONLM, Func<CancellationToken, Task<T>> LHIJFAFNKJL, int PLCNFJHNBMI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x85CD9B0", Offset = "0x85CC3B0", VA = "0x1885CD9B0")]
	[AsyncStateMachine(typeof(DOFAFALAMID))]
	internal Task MLDHJOAKHGN(CancellationToken IFGGPDNONLM, Func<CancellationToken, Task> LHIJFAFNKJL, int PLCNFJHNBMI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x85CD400", Offset = "0x85CBE00", VA = "0x1885CD400")]
	public NDOGPKHMOEO JEHBLNPFOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x85CD810", Offset = "0x85CC210", VA = "0x1885CD810")]
	public KFHIINKANJL LENDFCDACLO([Optional] ALOJOEEMFDJ GCDDKKMJIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x85CD5A0", Offset = "0x85CBFA0", VA = "0x1885CD5A0")]
	public JLICKIMDGLN KNNDDIKDCBE([Optional] COJJKFBGGKB? PMPMPCJHKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x85CDAE0", Offset = "0x85CC4E0", VA = "0x1885CDAE0")]
	public void NEIBKADGCLB(Func<Guid, bool> HHHECHBGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x85CD8A0", Offset = "0x85CC2A0", VA = "0x1885CD8A0")]
	public void MIDNLDDFPKD(Func<Guid, bool> LGEPPKICFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x85CCCD0", Offset = "0x85CB6D0", VA = "0x1885CCCD0")]
	public Guid DBDFJFPMIMN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x85CD080", Offset = "0x85CBA80", VA = "0x1885CD080")]
	public void HBEAGALHBDI(Guid FILKMFGCAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x85CD190", Offset = "0x85CBB90", VA = "0x1885CD190")]
	public void IGMOFKMPLIE(OBIDIGOJIIL MABGEPGOCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x85CDC40", Offset = "0x85CC640", VA = "0x1885CDC40")]
	public void NLLEOCMFOCP(string KJDOABOFEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8440", Offset = "0x3AC6E40", VA = "0x183AC8440")]
	private T CIEIMKHOKLD<T>(T PCDAHJCDHHF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x85CDD50", Offset = "0x85CC750", VA = "0x1885CDD50")]
	public void PBCCILCOGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8670", Offset = "0x3AC7070", VA = "0x183AC8670")]
	[CompilerGenerated]
	internal static string EFKCGOKEAJJ<T>(byte[] OKLLDHNGOMI, int GDNCKEELMHF, KMMBCDGDLOC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal sealed class LCNGIAAEMKJ : CPEALFJADBF
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class NLHGOJIFMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NLHGOJIFMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x85D62A0", Offset = "0x85D4CA0", VA = "0x1885D62A0")]
		internal object HKNPEBJEBAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct NHHADHPCKLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public LCNGIAAEMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private MMPJCCHHOBG <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private KFHIINKANJL <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter<IONCCFOBBJM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x85D5230", Offset = "0x85D3C30", VA = "0x1885D5230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x85D6130", Offset = "0x85D4B30", VA = "0x1885D6130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct LPLFJANLHJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public LCNGIAAEMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<PFLGPOLCCPC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x85D2C50", Offset = "0x85D1650", VA = "0x1885D2C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x85D33F0", Offset = "0x85D1DF0", VA = "0x1885D33F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct CNACEMNLFGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public LCNGIAAEMKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<CGCLGPHBJCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x85C3970", Offset = "0x85C2370", VA = "0x1885C3970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x85C3C80", Offset = "0x85C2680", VA = "0x1885C3C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class HIDLGGNECIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public MMPJCCHHOBG presence;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HIDLGGNECIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x85CAA00", Offset = "0x85C9400", VA = "0x1885CAA00")]
		internal object DNOPAEJENAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly COJJKFBGGKB NLPJGOMOOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private static readonly COJJKFBGGKB LMOEDDMPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly JKKKLGNDOCB DCIMNMEKALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly AKIBJNGPBHA KPBAEDMDFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private readonly ALOJOEEMFDJ GCDDKKMJIOL;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x85D19C0", Offset = "0x85D03C0", VA = "0x1885D19C0")]
	public LCNGIAAEMKJ(JKKKLGNDOCB DCIMNMEKALL, AKIBJNGPBHA KPBAEDMDFGJ, Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, GIPKKFBMGMB OFLDFJILBNI, ALOJOEEMFDJ GCDDKKMJIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x85D16A0", Offset = "0x85D00A0", VA = "0x1885D16A0", Slot = "7")]
	[AsyncStateMachine(typeof(NHHADHPCKLD))]
	protected override Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x85D17F0", Offset = "0x85D01F0", VA = "0x1885D17F0")]
	[AsyncStateMachine(typeof(LPLFJANLHJD))]
	private Task OFKJFMBKGEM(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x85D13C0", Offset = "0x85CFDC0", VA = "0x1885D13C0")]
	[AsyncStateMachine(typeof(CNACEMNLFGN))]
	private Task<int> JLCKGMMJANO(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x85D14D0", Offset = "0x85CFED0", VA = "0x1885D14D0")]
	private MMPJCCHHOBG KCDIEBIIPJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class EHHDGFGOCPA : CPEALFJADBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct HKGMIJGBEID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public EHHDGFGOCPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<LOKCFGIBPOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x85CAB40", Offset = "0x85C9540", VA = "0x1885CAB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x85CB4F0", Offset = "0x85C9EF0", VA = "0x1885CB4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private readonly int AKGMHFNBJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly BAMNMDPIDIE CIFPMGHKBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly long LNPPHIAKEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly long GBKOPJHFMID;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public LOKCFGIBPOM BGIBAHACNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA09300", Offset = "0xA07D00", VA = "0x180A09300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x85C6CE0", Offset = "0x85C56E0", VA = "0x1885C6CE0")]
	public EHHDGFGOCPA(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, GIPKKFBMGMB OFLDFJILBNI, int AKGMHFNBJIK, BAMNMDPIDIE CIFPMGHKBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x85C6BC0", Offset = "0x85C55C0", VA = "0x1885C6BC0", Slot = "7")]
	[AsyncStateMachine(typeof(HKGMIJGBEID))]
	protected override Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal abstract class HFOJDLPNPLI : CPEALFJADBF
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class BHEGDNLBBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public HFOJDLPNPLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AECCBCEBOOE playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BHEGDNLBBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x85C12E0", Offset = "0x85BFCE0", VA = "0x1885C12E0")]
		internal Task KMCNKKHKHJA(JBLIEDANKLD<string>.CKADLEMJOGG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x85C1320", Offset = "0x85BFD20", VA = "0x1885C1320")]
		internal object NFLCBFKLDJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct LHMICJPDBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public HFOJDLPNPLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private BHEGDNLBBEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B70", Offset = "0x85D0570", VA = "0x1885D1B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x85D2480", Offset = "0x85D0E80", VA = "0x1885D2480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct PACAEHNEPNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AECCBCEBOOE playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public HFOJDLPNPLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x85D9AF0", Offset = "0x85D84F0", VA = "0x1885D9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x85DA0A0", Offset = "0x85D8AA0", VA = "0x1885DA0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x85CA930", Offset = "0x85C9330", VA = "0x1885CA930")]
	public HFOJDLPNPLI(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, GIPKKFBMGMB OFLDFJILBNI, string NDFLLOHCHGM, HPJOEAHNKPG OFENPOIFLNA, bool ECFEDOPPIJF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x85CA7F0", Offset = "0x85C91F0", VA = "0x1885CA7F0", Slot = "7")]
	[AsyncStateMachine(typeof(LHMICJPDBCH))]
	protected override Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task FDNIKNLJOFJ(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x85CA6B0", Offset = "0x85C90B0", VA = "0x1885CA6B0")]
	[AsyncStateMachine(typeof(PACAEHNEPNJ))]
	private Task BNNIAKHPPHF(IDisposable DGKIKOPCOJA, AECCBCEBOOE PMPKEPOMAPF, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal class MHGHAPCIIGN : CPEALFJADBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct HCKKNLFDFFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public MHGHAPCIIGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<KIPPLECGJII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x85C9FE0", Offset = "0x85C89E0", VA = "0x1885C9FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x85CA5D0", Offset = "0x85C8FD0", VA = "0x1885CA5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly GCBBLAMCFIM JABFDEBGCIN;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x85D3B70", Offset = "0x85D2570", VA = "0x1885D3B70")]
	public MHGHAPCIIGN(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, GIPKKFBMGMB OFLDFJILBNI, GCBBLAMCFIM JABFDEBGCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x85D3970", Offset = "0x85D2370", VA = "0x1885D3970", Slot = "6")]
	protected override string IOKIOBJOGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x85D3A50", Offset = "0x85D2450", VA = "0x1885D3A50", Slot = "7")]
	[AsyncStateMachine(typeof(HCKKNLFDFFE))]
	protected override Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal abstract class CPEALFJADBF : LGPLOLBMAEK
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public delegate Task EEFPFPLEODF(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class BGGKFIKGBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public JBLIEDANKLD<string>.CKADLEMJOGG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public CPEALFJADBF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BGGKFIKGBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x85C11B0", Offset = "0x85BFBB0", VA = "0x1885C11B0")]
		internal Task HFEKNBIFIOK(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class BLFBLPGDMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public BGGKFIKGBNN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BLFBLPGDMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x85C1410", Offset = "0x85BFE10", VA = "0x1885C1410")]
		internal object CHNKGKGGJNH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct CDHKFEKGHKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public CPEALFJADBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Func<CPEALFJADBF, JBLIEDANKLD<string>.CKADLEMJOGG, JJLOAOIEJAJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private BGGKFIKGBNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private JJLOAOIEJAJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x85C1E90", Offset = "0x85C0890", VA = "0x1885C1E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x85C3120", Offset = "0x85C1B20", VA = "0x1885C3120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct DIHJECMCKHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x85C4B10", Offset = "0x85C3510", VA = "0x1885C4B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x85C55B0", Offset = "0x85C3FB0", VA = "0x1885C55B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct PPGGCMNOFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CPEALFJADBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x85DAA00", Offset = "0x85D9400", VA = "0x1885DAA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x85DAD60", Offset = "0x85D9760", VA = "0x1885DAD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public readonly Guid NHEGPKBAFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public readonly ByteString DPPOHOPMIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public readonly GIPKKFBMGMB NNFDNLGHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	protected readonly string HNJGDMHOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private readonly HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private readonly bool ECFEDOPPIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly Queue<EEFPFPLEODF> CNPKBHFEAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly NEKLIGKEFGE LHNFBNFPLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly HPJOEAHNKPG OFENPOIFLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private bool LFIDHGGKKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public NBLBPMKGJIE AHBEBCGGMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public NBLBPMKGJIE HIMJLMFOIOP;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public HKFGPGHMLEK BGJODJJGMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x85C4250", Offset = "0x85C2C50", VA = "0x1885C4250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public LFINHENNLKA CNELLNIJCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x85C47F0", Offset = "0x85C31F0", VA = "0x1885C47F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x85C46F0", Offset = "0x85C30F0", VA = "0x1885C46F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KANDEFNDKGP NFNEIEHDMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x85C3FB0", Offset = "0x85C29B0", VA = "0x1885C3FB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x85C46D0", Offset = "0x85C30D0", VA = "0x1885C46D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x85C49B0", Offset = "0x85C33B0", VA = "0x1885C49B0")]
	protected CPEALFJADBF(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, GIPKKFBMGMB OFLDFJILBNI, string NDFLLOHCHGM, HPJOEAHNKPG OFENPOIFLNA, bool ECFEDOPPIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x85C42A0", Offset = "0x85C2CA0", VA = "0x1885C42A0", Slot = "6")]
	protected virtual string IOKIOBJOGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x85C4670", Offset = "0x85C3070", VA = "0x1885C4670")]
	public void LKFDENFCKPL(EEFPFPLEODF IHKJPCPFJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x85C3F90", Offset = "0x85C2990", VA = "0x1885C3F90")]
	protected void EGMHNALMHFF(float ADAFNPDOCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x85C4100", Offset = "0x85C2B00", VA = "0x1885C4100")]
	[AsyncStateMachine(typeof(CDHKFEKGHKP))]
	public Task IJLCGHNANIM(CancellationToken JKPNCAGHEDI, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, [Optional] Func<CPEALFJADBF, JBLIEDANKLD<string>.CKADLEMJOGG, JJLOAOIEJAJ> GGNOAIFKAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x85C3FD0", Offset = "0x85C29D0", VA = "0x1885C3FD0")]
	[AsyncStateMachine(typeof(DIHJECMCKHE))]
	private static Task GKDPFEBCKPJ(Func<CancellationToken, Task> CDOKJPGFGLC, Func<CancellationToken, Task> HFBHAOAJJPF, CancellationToken IFGGPDNONLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x85C4500", Offset = "0x85C2F00", VA = "0x1885C4500")]
	private void KECFMINFAML(bool CACGHLMLDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x85C42E0", Offset = "0x85C2CE0", VA = "0x1885C42E0")]
	private void JJFLNGALJAG(JJLOAOIEJAJ GJIGPFFHPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x85C3E70", Offset = "0x85C2870", VA = "0x1885C3E70")]
	[AsyncStateMachine(typeof(PPGGCMNOFIB))]
	private Task DKGILBALCJG(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x85C4770", Offset = "0x85C3170", VA = "0x1885C4770")]
	public OBIDIGOJIIL MMEAALBONCL(KGPCDCOMIDE GMEDBPGLFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x85C4840", Offset = "0x85C3240", VA = "0x1885C4840")]
	[CompilerGenerated]
	private Task OHOCCIJPPGC(CancellationToken ANAFNAJGANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x85C4930", Offset = "0x85C3330", VA = "0x1885C4930")]
	[CompilerGenerated]
	private object PEJKFOGLOKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal sealed class FHNJCMPBMLC : HFOJDLPNPLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct JCKCAOAKHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public FHNJCMPBMLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private NPPCBBFHGKB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private KFHIINKANJL <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x85CC440", Offset = "0x85CAE40", VA = "0x1885CC440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x85CCBB0", Offset = "0x85CB5B0", VA = "0x1885CCBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly JKKKLGNDOCB HMAAOHAGCJO;

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x85C73C0", Offset = "0x85C5DC0", VA = "0x1885C73C0")]
	public FHNJCMPBMLC(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, JKKKLGNDOCB HMAAOHAGCJO, GIPKKFBMGMB OFLDFJILBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x85C7270", Offset = "0x85C5C70", VA = "0x1885C7270", Slot = "8")]
	[AsyncStateMachine(typeof(JCKCAOAKHLE))]
	protected override Task FDNIKNLJOFJ(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class PHDHOEPGIJE : CPEALFJADBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct PGHIOKBNMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public PHDHOEPGIJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private TaskAwaiter<KIPPLECGJII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x85DA350", Offset = "0x85D8D50", VA = "0x1885DA350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x85DA7E0", Offset = "0x85D91E0", VA = "0x1885DA7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly string HFGEHHJHHKG;

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x85DA950", Offset = "0x85D9350", VA = "0x1885DA950")]
	public PHDHOEPGIJE(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, GIPKKFBMGMB OFLDFJILBNI, string HFGEHHJHHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x85DA840", Offset = "0x85D9240", VA = "0x1885DA840", Slot = "7")]
	[AsyncStateMachine(typeof(PGHIOKBNMAL))]
	protected override Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class MMFIJEFJCLG : HFOJDLPNPLI
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class GJOOLOGNCFP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public GJOOLOGNCFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private TaskAwaiter<KIPPLECGJII> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			private TaskAwaiter<OBIDIGOJIIL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x85DADC0", Offset = "0x85D97C0", VA = "0x1885DADC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x85DB2B0", Offset = "0x85D9CB0", VA = "0x1885DB2B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public MMFIJEFJCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public JLICKIMDGLN serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public NACFJGFGJCK roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public NDOGPKHMOEO uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public MCOPGAMEPGG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GJOOLOGNCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x85C98A0", Offset = "0x85C82A0", VA = "0x1885C98A0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<OBIDIGOJIIL> GIIOACEBPNO(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct OPKEMGGOEBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public MMFIJEFJCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private GJOOLOGNCFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private NPPCBBFHGKB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private KFHIINKANJL <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private OBIDIGOJIIL <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x85D8BA0", Offset = "0x85D75A0", VA = "0x1885D8BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x85D9A90", Offset = "0x85D8490", VA = "0x1885D9A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private static readonly COJJKFBGGKB NLPJGOMOOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private readonly int DPBNEMHNHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	[CanBeNull]
	private readonly DMEFFBPJOFP PBNMCEIBAFO;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x85D40D0", Offset = "0x85D2AD0", VA = "0x1885D40D0")]
	public MMFIJEFJCLG(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, int DPBNEMHNHCP, DMEFFBPJOFP PBNMCEIBAFO, GIPKKFBMGMB OFLDFJILBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x85D3EE0", Offset = "0x85D28E0", VA = "0x1885D3EE0", Slot = "8")]
	[AsyncStateMachine(typeof(OPKEMGGOEBI))]
	protected override Task FDNIKNLJOFJ(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x85D3C10", Offset = "0x85D2610", VA = "0x1885D3C10")]
	private void DBMBKJKGDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x85D3D10", Offset = "0x85D2710", VA = "0x1885D3D10")]
	private void DOIICIADDNK(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, NPPCBBFHGKB MAHHBHOMIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class MPDGGMIPCBP : CPEALFJADBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct GCGOMLBOLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public MPDGGMIPCBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private NPPCBBFHGKB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private CGCLGPHBJCJ <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private ODDHNIEMFCD<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter<CGCLGPHBJCJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter<LOKCFGIBPOM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x85C8420", Offset = "0x85C6E20", VA = "0x1885C8420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x85C9840", Offset = "0x85C8240", VA = "0x1885C9840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly int DPBNEMHNHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly DMEFFBPJOFP PBNMCEIBAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private Func<KIPPLECGJII, KIPPLECGJII> DPPMLEONLPD;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x85D4370", Offset = "0x85D2D70", VA = "0x1885D4370")]
	public MPDGGMIPCBP(Guid CFNOFGNKICA, HKFGPGHMLEK DLDEJAGLCHP, int DPBNEMHNHCP, DMEFFBPJOFP PBNMCEIBAFO, Func<KIPPLECGJII, KIPPLECGJII> DPPMLEONLPD, GIPKKFBMGMB OFLDFJILBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x85D4240", Offset = "0x85D2C40", VA = "0x1885D4240", Slot = "7")]
	[AsyncStateMachine(typeof(GCGOMLBOLAD))]
	protected override Task LHCHMABOGKK(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal abstract class OBBJEBDKKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public readonly CPEALFJADBF PKCFNJINFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public readonly JJLOAOIEJAJ DNKENJPHAKI;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x85D6570", Offset = "0x85D4F70", VA = "0x1885D6570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x85D65C0", Offset = "0x85D4FC0", VA = "0x1885D65C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x85D6760", Offset = "0x85D5160", VA = "0x1885D6760")]
	protected OBBJEBDKKFK(JJLOAOIEJAJ GJIGPFFHPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x85D6650", Offset = "0x85D5050", VA = "0x1885D6650")]
	protected void NLLEOCMFOCP(string KJDOABOFEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct NBPDAJHEIMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public Dictionary<Guid, List<MPALOKCIKAK>> LBOPPIIBDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public Dictionary<Guid, List<MPALOKCIKAK>> CNOBEBOKOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public Dictionary<Guid, List<MPALOKCIKAK>> MBLMGCOFODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public List<Guid> OBKJCKMIAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x85D4430", Offset = "0x85D2E30", VA = "0x1885D4430")]
	public static NBPDAJHEIMO IBPMNADNGOO(EJALGCLEMLF FLJMNPJIKOM, NBLBPMKGJIE IFFNNAAMEMJ, JFCHLDJHBKP KMLLEPPHFEF)
	{
		return default(NBPDAJHEIMO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct PMIEDNFFONK
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	public static PMIEDNFFONK JEBOFNEMEAN()
	{
		return default(PMIEDNFFONK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct FKNMGFLNFFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public readonly PFLGPOLCCPC DOMHKNEHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public readonly BBAIIGBMJIM KKAMNKFOEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public readonly Guid? GJEEKGJKBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public readonly IReadOnlyCollection<CCIEPLLJIFN> NENPIFCAJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public readonly IReadOnlyCollection<CCIEPLLJIFN> ODGALKHABCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public readonly LKFLNLIEOOH OHHJLEDHKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly LKFLNLIEOOH AFJBMFELNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly FIDOJLMNKGC DKNHMDJKKIC;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool ACHHCMDOFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x85C7EB0", Offset = "0x85C68B0", VA = "0x1885C7EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x85C7F40", Offset = "0x85C6940", VA = "0x1885C7F40")]
	public FKNMGFLNFFM(PFLGPOLCCPC DOMHKNEHBED, BBAIIGBMJIM KKAMNKFOEEF, Guid? GJEEKGJKBGO, IReadOnlyList<CCIEPLLJIFN> NENPIFCAJKP, IReadOnlyCollection<CCIEPLLJIFN> ODGALKHABCJ, LKFLNLIEOOH OHHJLEDHKKJ, LKFLNLIEOOH AFJBMFELNHB, FIDOJLMNKGC DKNHMDJKKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct ADPCEJCAADJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private readonly JJLOAOIEJAJ GJIGPFFHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private readonly Guid FILKMFGCAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private bool CACGHLMLDCI;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x85BFBF0", Offset = "0x85BE5F0", VA = "0x1885BFBF0")]
	public static ADPCEJCAADJ DBDFJFPMIMN(JJLOAOIEJAJ GJIGPFFHPEC)
	{
		return default(ADPCEJCAADJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x1243F90", Offset = "0x1242990", VA = "0x181243F90")]
	public void POBNBIMJNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x85BFC20", Offset = "0x85BE620", VA = "0x1885BFC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x85BFF00", Offset = "0x85BE900", VA = "0x1885BFF00")]
	private ADPCEJCAADJ(JJLOAOIEJAJ GJIGPFFHPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x85BFC30", Offset = "0x85BE630", VA = "0x1885BFC30")]
	private void HBEAGALHBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x85BFE60", Offset = "0x85BE860", VA = "0x1885BFE60")]
	private Func<Guid, bool> MNKEELHLABK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal class KFHIINKANJL : OBBJEBDKKFK, LGPLOLBMAEK
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public delegate Task<NBLBPMKGJIE> IOMPPOCPIBA(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA FHLHJFDGKGE, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct KPOIOHDOLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public JKKKLGNDOCB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ADPCEJCAADJ <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x85EAD90", Offset = "0x85E9790", VA = "0x1885EAD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB4D0", Offset = "0x85E9ED0", VA = "0x1885EB4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct FFLNAJAAMIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public JKKKLGNDOCB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x85E2930", Offset = "0x85E1330", VA = "0x1885E2930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x85E2D60", Offset = "0x85E1760", VA = "0x1885E2D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct KKDKPOANJPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public JKKKLGNDOCB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x85E9960", Offset = "0x85E8360", VA = "0x1885E9960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E20", Offset = "0x85E8820", VA = "0x1885E9E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class JBLBAAEJGFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public AsyncTaskMethodBuilder<FKNMGFLNFFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public JBLBAAEJGFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			private FKNMGFLNFFM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private TaskAwaiter<NBLBPMKGJIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			private TaskAwaiter<FKNMGFLNFFM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x85F0FA0", Offset = "0x85EF9A0", VA = "0x1885F0FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x85F1860", Offset = "0x85F0260", VA = "0x1885F1860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public AsyncTaskMethodBuilder<JFCHLDJHBKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public JBLBAAEJGFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private JFCHLDJHBKP <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<NBLBPMKGJIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			private TaskAwaiter<JFCHLDJHBKP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x85F18D0", Offset = "0x85F02D0", VA = "0x1885F18D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x85F1F20", Offset = "0x85F0920", VA = "0x1885F1F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public JKKKLGNDOCB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public NEKLIGKEFGE preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public NEKLIGKEFGE downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public FKNMGFLNFFM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public NEKLIGKEFGE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public JFCHLDJHBKP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public FKKEGKBKICJ.PAADLMLBGCD <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JBLBAAEJGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x85E7400", Offset = "0x85E5E00", VA = "0x1885E7400")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<FKNMGFLNFFM> GLPOKLMLEJN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x85E7590", Offset = "0x85E5F90", VA = "0x1885E7590")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<JFCHLDJHBKP> NOKFJEPPCON(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x85E73C0", Offset = "0x85E5DC0", VA = "0x1885E73C0")]
		internal void GCFOKCKNNNA(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x85E7380", Offset = "0x85E5D80", VA = "0x1885E7380")]
		internal Task AFFOLJJKGAK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x85E7550", Offset = "0x85E5F50", VA = "0x1885E7550")]
		internal Task MGFKEFMLJBA(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct HINBNMILLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public JKKKLGNDOCB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private JBLBAAEJGFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<FKNMGFLNFFM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private TaskAwaiter<JFCHLDJHBKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x85E5780", Offset = "0x85E4180", VA = "0x1885E5780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x85E6430", Offset = "0x85E4E30", VA = "0x1885E6430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct GOENKDFHAJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public JFCHLDJHBKP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public NEKLIGKEFGE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private BKLLEOOLBCA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x85E3F40", Offset = "0x85E2940", VA = "0x1885E3F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x85E4DA0", Offset = "0x85E37A0", VA = "0x1885E4DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct LCEOAJNEJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x85EB530", Offset = "0x85E9F30", VA = "0x1885EB530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x85EBD10", Offset = "0x85EA710", VA = "0x1885EBD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct EGACBCCMOIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x85E1370", Offset = "0x85DFD70", VA = "0x1885E1370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x85E1BB0", Offset = "0x85E05B0", VA = "0x1885E1BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct BHMMLJEHPJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x85DCB10", Offset = "0x85DB510", VA = "0x1885DCB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x85DDAD0", Offset = "0x85DC4D0", VA = "0x1885DDAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct OMNJJOGFMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public BKLLEOOLBCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x85EE0E0", Offset = "0x85ECAE0", VA = "0x1885EE0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x85EF1F0", Offset = "0x85EDBF0", VA = "0x1885EF1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct JBKAFBHCBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public NBLBPMKGJIE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public JFCHLDJHBKP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x85E70B0", Offset = "0x85E5AB0", VA = "0x1885E70B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x85E7310", Offset = "0x85E5D10", VA = "0x1885E7310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class NHIIHEAPJBB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public NHIIHEAPJBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			private EJBJHLMGBBN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			private TaskAwaiter<NBLBPMKGJIE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x85F1F90", Offset = "0x85F0990", VA = "0x1885F1F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x85F25B0", Offset = "0x85F0FB0", VA = "0x1885F25B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public IOMPPOCPIBA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public BKLLEOOLBCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public NBLBPMKGJIE originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NHIIHEAPJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x85EC5B0", Offset = "0x85EAFB0", VA = "0x1885EC5B0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<NBLBPMKGJIE> BEGAJOIGEAJ(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct OGFEGKPOIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public IOMPPOCPIBA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public BKLLEOOLBCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x85EDB50", Offset = "0x85EC550", VA = "0x1885EDB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x85EE070", Offset = "0x85ECA70", VA = "0x1885EE070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct DLNPJFKPKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private NBLBPMKGJIE <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private IEnumerator<NBLBPMKGJIE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x85E0560", Offset = "0x85DEF60", VA = "0x1885E0560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x85E0AC0", Offset = "0x85DF4C0", VA = "0x1885E0AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct AECOHFJAPGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x85DBBB0", Offset = "0x85DA5B0", VA = "0x1885DBBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x85DBEA0", Offset = "0x85DA8A0", VA = "0x1885DBEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct JJEPCFJBNBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x85E86C0", Offset = "0x85E70C0", VA = "0x1885E86C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x85E88E0", Offset = "0x85E72E0", VA = "0x1885E88E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class JHIBGAAINEA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public JHIBGAAINEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public JFCHLDJHBKP data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public NEKLIGKEFGE progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private TaskAwaiter<NBLBPMKGJIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			private TaskAwaiter<PBDEMOHAMJE> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x85F2620", Offset = "0x85F1020", VA = "0x1885F2620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x85F30F0", Offset = "0x85F1AF0", VA = "0x1885F30F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public DIOBDIFFCMA mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JHIBGAAINEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x85E8560", Offset = "0x85E6F60", VA = "0x1885E8560")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<NBLBPMKGJIE> INCBINIFNKO(JFCHLDJHBKP data, BKLLEOOLBCA _, NEKLIGKEFGE progressTracker, JBLIEDANKLD<string>.CKADLEMJOGG stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct JFOOGICKHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public JFCHLDJHBKP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public NEKLIGKEFGE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private JHIBGAAINEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private BKLLEOOLBCA <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x85E76B0", Offset = "0x85E60B0", VA = "0x1885E76B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x85E8500", Offset = "0x85E6F00", VA = "0x1885E8500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct LCPNFFENAJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x85EBD70", Offset = "0x85EA770", VA = "0x1885EBD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x85EC170", Offset = "0x85EAB70", VA = "0x1885EC170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct KMPLIPGMIAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public KFHIINKANJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public NEKLIGKEFGE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x85EA700", Offset = "0x85E9100", VA = "0x1885EA700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x85EAD20", Offset = "0x85E9720", VA = "0x1885EAD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private readonly EPPGEGDDHJJ BFJOHKNDODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly EPPGEGDDHJJ JEGAIBNNBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private readonly EGNOIGEDNKF DOGCKMIKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly ELLKHNFNFKK MNLLGPIJKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly KPPIBCMDCAJ IEGBEJEACAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private ProfilerCounterValue<int> MEHEOANELIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly BMDFAIOFFAL KLLNMIAGDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly ALOJOEEMFDJ GCDDKKMJIOL;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private HKFGPGHMLEK BGJODJJGMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x85CFFB0", Offset = "0x85CE9B0", VA = "0x1885CFFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KANDEFNDKGP NFNEIEHDMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x85CF400", Offset = "0x85CDE00", VA = "0x1885CF400", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x85CFCF0", Offset = "0x85CE6F0", VA = "0x1885CFCF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x85D0120", Offset = "0x85CEB20", VA = "0x1885D0120")]
	public KFHIINKANJL(JJLOAOIEJAJ GJIGPFFHPEC, ALOJOEEMFDJ GCDDKKMJIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x85CFA00", Offset = "0x85CE400", VA = "0x1885CFA00")]
	[AsyncStateMachine(typeof(KPOIOHDOLDP))]
	public Task JOONIIIJPOF(JKKKLGNDOCB OHOKHLNBDDB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x85CF1B0", Offset = "0x85CDBB0", VA = "0x1885CF1B0")]
	[AsyncStateMachine(typeof(FFLNAJAAMIO))]
	private Task<OBIDIGOJIIL> FIHFFGPJCLK(JKKKLGNDOCB OHOKHLNBDDB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x85CF420", Offset = "0x85CDE20", VA = "0x1885CF420")]
	[AsyncStateMachine(typeof(KKDKPOANJPB))]
	private Task FMOICCOBOOL(JKKKLGNDOCB OHOKHLNBDDB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x85CF880", Offset = "0x85CE280", VA = "0x1885CF880")]
	[AsyncStateMachine(typeof(HINBNMILLHG))]
	private Task IGKCCNPEHOF(JKKKLGNDOCB OHOKHLNBDDB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken KFPKAAMDIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x85CF060", Offset = "0x85CDA60", VA = "0x1885CF060")]
	[AsyncStateMachine(typeof(GOENKDFHAJL))]
	private Task FAJJNLMJCNA(JFCHLDJHBKP OIFFCAEJEOF, NEKLIGKEFGE GDIHHPBEAOB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken DKBGEPEEKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x85CEC20", Offset = "0x85CD620", VA = "0x1885CEC20")]
	[AsyncStateMachine(typeof(LCEOAJNEJGA))]
	private Task DABIMMAMCPL(JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x85CED30", Offset = "0x85CD730", VA = "0x1885CED30")]
	[AsyncStateMachine(typeof(EGACBCCMOIH))]
	private Task ECDMFEHNLML(JFCHLDJHBKP HPGIDELCODH, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x85CF720", Offset = "0x85CE120", VA = "0x1885CF720")]
	[AsyncStateMachine(typeof(BHMMLJEHPJC))]
	private Task<NBLBPMKGJIE> HIAJCKEJCOO(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x85CEEE0", Offset = "0x85CD8E0", VA = "0x1885CEEE0")]
	[AsyncStateMachine(typeof(OMNJJOGFMDB))]
	private Task<NBLBPMKGJIE> EOBJPLOBHLA(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x85CE560", Offset = "0x85CCF60", VA = "0x1885CE560")]
	[AsyncStateMachine(typeof(JBKAFBHCBJG))]
	private Task<NBLBPMKGJIE> AACHABIBLGA(NBLBPMKGJIE IFFNNAAMEMJ, JFCHLDJHBKP KMLLEPPHFEF, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI, bool KKFHPJJIJJC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x85CFEA0", Offset = "0x85CE8A0", VA = "0x1885CFEA0")]
	private bool MJPOKBNJCEH(JFCHLDJHBKP OIFFCAEJEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x85CE9E0", Offset = "0x85CD3E0", VA = "0x1885CE9E0")]
	[AsyncStateMachine(typeof(OGFEGKPOIDI))]
	protected Task<NBLBPMKGJIE> BEDILDCCINB(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI, IOMPPOCPIBA ECCNJMDBDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x85CF580", Offset = "0x85CDF80", VA = "0x1885CF580")]
	[AsyncStateMachine(typeof(DLNPJFKPKJA))]
	private Task FNHLIJHIOLE(JFCHLDJHBKP HPGIDELCODH, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x85CFB50", Offset = "0x85CE550", VA = "0x1885CFB50")]
	private void KFCAACEPGGF(NBLBPMKGJIE FHDHBANKEDI, NEKLIGKEFGE HPNEOCEEIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x85CFE60", Offset = "0x85CE860", VA = "0x1885CFE60")]
	private void MJKPGPOPFAK(NBLBPMKGJIE PNFCHCPBEOC, [Out] NBLBPMKGJIE DMPBDMHLEGE, [Out] NBLBPMKGJIE CKNNGMFOOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x85CF9C0", Offset = "0x85CE3C0", VA = "0x1885CF9C0")]
	private Task<FKNMGFLNFFM> ILOGGJOJPGI(JKKKLGNDOCB OHOKHLNBDDB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x85CEEA0", Offset = "0x85CD8A0", VA = "0x1885CEEA0")]
	private Task<JFCHLDJHBKP> EHLABKDIMHK(FKNMGFLNFFM HPGIDELCODH, FKKEGKBKICJ.PAADLMLBGCD INPBDLCMNLK, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x85CE840", Offset = "0x85CD240", VA = "0x1885CE840")]
	[AsyncStateMachine(typeof(AECOHFJAPGL))]
	private Task ACELMPNMLCD(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI, bool OBGLIJMJOJB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x85CF310", Offset = "0x85CDD10", VA = "0x1885CF310")]
	[AsyncStateMachine(typeof(JJEPCFJBNBH))]
	private Task FJKCBAJPPCO(JFCHLDJHBKP HPGIDELCODH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x85CE9B0", Offset = "0x85CD3B0", VA = "0x1885CE9B0")]
	private Task APCMGNDCJAP(JFCHLDJHBKP HPGIDELCODH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x85CFFE0", Offset = "0x85CE9E0", VA = "0x1885CFFE0")]
	private Task PJKGIJKPKEH(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x85CF560", Offset = "0x85CDF60", VA = "0x1885CF560")]
	private Task FNGOIKKFLDG(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x85CEE80", Offset = "0x85CD880", VA = "0x1885CEE80")]
	private Task EDMJCPAJJCK(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x85CFD10", Offset = "0x85CE710", VA = "0x1885CFD10")]
	private static Task MDDKODMKBMB(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x85CE990", Offset = "0x85CD390", VA = "0x1885CE990")]
	private Task ANHFBFKJIHL(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x85CFF90", Offset = "0x85CE990", VA = "0x1885CFF90")]
	private Task NBNOGBGBCFC(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x85CF6D0", Offset = "0x85CE0D0", VA = "0x1885CF6D0")]
	private void GNGCNDANHGJ(JKKKLGNDOCB OHOKHLNBDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x85CEB70", Offset = "0x85CD570", VA = "0x1885CEB70")]
	public void CBKOEKEEBFB(long LOMEDBPBLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void FBNGKMKBLCA(PFLGPOLCCPC DOMHKNEHBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x85CFBA0", Offset = "0x85CE5A0", VA = "0x1885CFBA0")]
	[AsyncStateMachine(typeof(JFOOGICKHEE))]
	private Task LBCECFODJIP(JFCHLDJHBKP OIFFCAEJEOF, NEKLIGKEFGE GDIHHPBEAOB, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken DKBGEPEEKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x85CFD20", Offset = "0x85CE720", VA = "0x1885CFD20")]
	[AsyncStateMachine(typeof(LCPNFFENAJA))]
	private Task MENKBINPMBJ(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x85D0000", Offset = "0x85CEA00", VA = "0x1885D0000")]
	private static NEGEMEPEKGJ PMKHLPBLPLP(JFCHLDJHBKP KMLLEPPHFEF)
	{
		return default(NEGEMEPEKGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x85CE6E0", Offset = "0x85CD0E0", VA = "0x1885CE6E0")]
	[AsyncStateMachine(typeof(KMPLIPGMIAM))]
	private Task<NBLBPMKGJIE> AAMNCFGOIAA(JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, NEKLIGKEFGE HPNEOCEEIHE, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private void NHJIOKKKMCD(NBLBPMKGJIE HKKLJHFJOOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct NJLBDOIJFDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private JFCHLDJHBKP HPGIDELCODH;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x85EC9C0", Offset = "0x85EB3C0", VA = "0x1885EC9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x85EC8E0", Offset = "0x85EB2E0", VA = "0x1885EC8E0")]
	public static Task IJLCGHNANIM(HKFGPGHMLEK DLDEJAGLCHP, JFCHLDJHBKP HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x85EC6D0", Offset = "0x85EB0D0", VA = "0x1885EC6D0")]
	private void IJLCGHNANIM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct IJLKALOENNI
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x85E6FD0", Offset = "0x85E59D0", VA = "0x1885E6FD0")]
	public static Task IJLCGHNANIM(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct NAOCIAPGFBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct DIBCNFOGJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x85DFFD0", Offset = "0x85DE9D0", VA = "0x1885DFFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x85E0500", Offset = "0x85DEF00", VA = "0x1885E0500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x85EC470", Offset = "0x85EAE70", VA = "0x1885EC470")]
	[AsyncStateMachine(typeof(DIBCNFOGJBA))]
	public static Task IJLCGHNANIM(JJLOAOIEJAJ GJIGPFFHPEC, JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct CDILPOCDKAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct CFGJDPEJPAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public BKLLEOOLBCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private HKFGPGHMLEK <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private EJALGCLEMLF <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private NBLBPMKGJIE <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private EJBJHLMGBBN <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private List<(PersistenceView, CEIEJPOFNOJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private CEIEJPOFNOJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x85DE9E0", Offset = "0x85DD3E0", VA = "0x1885DE9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x85DF6B0", Offset = "0x85DE0B0", VA = "0x1885DF6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x85DE890", Offset = "0x85DD290", VA = "0x1885DE890")]
	[AsyncStateMachine(typeof(CFGJDPEJPAJ))]
	public static Task IJLCGHNANIM(JJLOAOIEJAJ GJIGPFFHPEC, JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x85DE6A0", Offset = "0x85DD0A0", VA = "0x1885DE6A0")]
	private static void HKAJGNCNJAN(PersistenceView MMGGIIKGBNM, CEIEJPOFNOJ IMNAAJEOHCB, JFCHLDJHBKP HPGIDELCODH, NBLBPMKGJIE IFFNNAAMEMJ, bool ABPMPKLKFJM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct EPIBEDPPKHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct JNLAOCCEJPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public HKFGPGHMLEK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private EJBJHLMGBBN <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x85E8940", Offset = "0x85E7340", VA = "0x1885E8940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x85E8F60", Offset = "0x85E7960", VA = "0x1885E8F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x85E2810", Offset = "0x85E1210", VA = "0x1885E2810")]
	[AsyncStateMachine(typeof(JNLAOCCEJPB))]
	public static Task IJLCGHNANIM(HKFGPGHMLEK DLDEJAGLCHP, JFCHLDJHBKP HPGIDELCODH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct BAGHMNNFGCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct AAOKCABHPGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public HKFGPGHMLEK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x85DB940", Offset = "0x85DA340", VA = "0x1885DB940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x85DBB50", Offset = "0x85DA550", VA = "0x1885DBB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class NKKKINICDCL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public JBLIEDANKLD<string>.CKADLEMJOGG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public NKKKINICDCL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x85F3160", Offset = "0x85F1B60", VA = "0x1885F3160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x85F34F0", Offset = "0x85F1EF0", VA = "0x1885F34F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NKKKINICDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x85ECA10", Offset = "0x85EB410", VA = "0x1885ECA10")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task KAAFLKOHNEN(JBLIEDANKLD<string>.CKADLEMJOGG timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct PGBGKHDMBBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public BAGHMNNFGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private EJBJHLMGBBN <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x85EF930", Offset = "0x85EE330", VA = "0x1885EF930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x85F0530", Offset = "0x85EEF30", VA = "0x1885F0530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class HFDHEMDPJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public OGEHLNKGNIL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HFDHEMDPJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x85E55F0", Offset = "0x85E3FF0", VA = "0x1885E55F0")]
		internal object JNHHIOBKPHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x85E56D0", Offset = "0x85E40D0", VA = "0x1885E56D0")]
		internal object NOODHCLILCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private JFCHLDJHBKP HPGIDELCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private JJLOAOIEJAJ GJIGPFFHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private bool OBGLIJMJOJB;

	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private static readonly ByteString ADILHCMPNMO;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x85DC990", Offset = "0x85DB390", VA = "0x1885DC990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private JOFBKCGIJED GJELDCPAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x85DC9E0", Offset = "0x85DB3E0", VA = "0x1885DC9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x85DC710", Offset = "0x85DB110", VA = "0x1885DC710")]
	[AsyncStateMachine(typeof(AAOKCABHPGC))]
	public static Task IJLCGHNANIM(HKFGPGHMLEK DLDEJAGLCHP, JFCHLDJHBKP HPGIDELCODH, JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI, bool OBGLIJMJOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x85DC860", Offset = "0x85DB260", VA = "0x1885DC860")]
	[AsyncStateMachine(typeof(PGBGKHDMBBL))]
	private Task IJLCGHNANIM(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x85DBF40", Offset = "0x85DA940", VA = "0x1885DBF40")]
	private void DADBGKCJPFH([NotNull] BGHEHCDAEKD DJMELIEHAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x85DBF00", Offset = "0x85DA900", VA = "0x1885DBF00")]
	private bool BOONGDJIHAN(OGEHLNKGNIL GPMAOGCPKOA, BGHEHCDAEKD DJMELIEHAHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct KMGOLDJJADF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct FGOGHKDMEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public AsyncTaskMethodBuilder<JFCHLDJHBKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public KMGOLDJJADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public FKKEGKBKICJ.PAADLMLBGCD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter<IReadOnlyCollection<CCIEPLLJIFN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private TaskAwaiter<(KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>, KAFLOHEKGBO<GODECPCJOOD<BGHEHCDAEKD>, GJIFJLKDAGC>, KAFLOHEKGBO<GODECPCJOOD<FKOCDIMDNEB>, GJIFJLKDAGC>, KAFLOHEKGBO<GODECPCJOOD<IEnumerable<KFMMELOCOBN>>, GJIFJLKDAGC>, KAFLOHEKGBO<GODECPCJOOD<LANBKINAPGH>, GJIFJLKDAGC>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x85E2DD0", Offset = "0x85E17D0", VA = "0x1885E2DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x85E3BB0", Offset = "0x85E25B0", VA = "0x1885E3BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct PGAOLBAFKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public JBLIEDANKLD<string>.CKADLEMJOGG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public KMGOLDJJADF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public IReadOnlyCollection<CCIEPLLJIFN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public IReadOnlyCollection<CCIEPLLJIFN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public FKKEGKBKICJ.PAADLMLBGCD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x85EF260", Offset = "0x85EDC60", VA = "0x1885EF260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x85EF8C0", Offset = "0x85EE2C0", VA = "0x1885EF8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private ODBFDHFNLPH<LKFLNLIEOOH, FKOCDIMDNEB> OEHNIIOFMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private ODBFDHFNLPH<LKFLNLIEOOH, BGHEHCDAEKD> HKDCJECPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private ODBFDHFNLPH<FIDOJLMNKGC, IEnumerable<KFMMELOCOBN>> IJCCMPDKCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private ODBFDHFNLPH<long, LANBKINAPGH> FNIPIBDKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private CGHCFDNOEBP DAEGGBCBBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private PFLGPOLCCPC DOMHKNEHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private BBAIIGBMJIM KKAMNKFOEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private Guid? GJEEKGJKBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private IReadOnlyCollection<CCIEPLLJIFN> NENPIFCAJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private Task<IReadOnlyCollection<CCIEPLLJIFN>> BAICJHHFIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private LKFLNLIEOOH OHHJLEDHKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private LKFLNLIEOOH AFJBMFELNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private LKFLNLIEOOH? HAENKMJHJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private FIDOJLMNKGC DKNHMDJKKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x85EA260", Offset = "0x85E8C60", VA = "0x1885EA260")]
	public static Task<JFCHLDJHBKP> KGMOPGPHGJI(HKFGPGHMLEK DLDEJAGLCHP, [In] FKNMGFLNFFM HPGIDELCODH, FKKEGKBKICJ.PAADLMLBGCD INPBDLCMNLK, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x85EA0B0", Offset = "0x85E8AB0", VA = "0x1885EA0B0")]
	[AsyncStateMachine(typeof(FGOGHKDMEEO))]
	private Task<JFCHLDJHBKP> IJLCGHNANIM(FKKEGKBKICJ.PAADLMLBGCD INPBDLCMNLK, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E80", Offset = "0x85E8880", VA = "0x1885E9E80")]
	[AsyncStateMachine(typeof(PGAOLBAFKCH))]
	private Task<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> CCHPEMMOBBG(Guid? GJEEKGJKBGO, IReadOnlyCollection<CCIEPLLJIFN> NENPIFCAJKP, IReadOnlyCollection<CCIEPLLJIFN> ODGALKHABCJ, long? FHOIPEIAACP, long? IIHAMPMIGID, FKKEGKBKICJ.PAADLMLBGCD INPBDLCMNLK, JBLIEDANKLD<string>.CKADLEMJOGG PBCAHBOLDCF, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct EHANKKIDAAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct KGALEAMBPEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public AsyncTaskMethodBuilder<FKNMGFLNFFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public EHANKKIDAAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter<FKNMGFLNFFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x85E94A0", Offset = "0x85E7EA0", VA = "0x1885E94A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x85E98F0", Offset = "0x85E82F0", VA = "0x1885E98F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct BJLNIHBCEPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<FKNMGFLNFFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public EHANKKIDAAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<FKNMGFLNFFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x85DE1B0", Offset = "0x85DCBB0", VA = "0x1885DE1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x85DE630", Offset = "0x85DD030", VA = "0x1885DE630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class FOKMHBKEALL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public FOKMHBKEALL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			private TaskAwaiter<CIJBIBHOKLO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private TaskAwaiter<CGCLGPHBJCJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x85F0590", Offset = "0x85EEF90", VA = "0x1885F0590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x85F0F40", Offset = "0x85EF940", VA = "0x1885F0F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public FKLEENCAODN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public EJALGCLEMLF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public LKFLNLIEOOH superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public LKFLNLIEOOH subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public IReadOnlyList<CCIEPLLJIFN> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public IReadOnlyList<CCIEPLLJIFN> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public PFLGPOLCCPC roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FOKMHBKEALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xEFEA00", Offset = "0xEFD400", VA = "0x180EFEA00")]
		internal bool LDAGHMNAAJK(BBAIIGBMJIM sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x85E3C20", Offset = "0x85E2620", VA = "0x1885E3C20")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task AJOIACIHEIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x85E3CF0", Offset = "0x85E26F0", VA = "0x1885E3CF0")]
		internal Task<FIDOJLMNKGC> FIFOJPDHFNO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct OEGJFCCKJLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<FKNMGFLNFFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public FKLEENCAODN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public EJALGCLEMLF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public LKFLNLIEOOH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private FOKMHBKEALL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private BBAIIGBMJIM <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private Task<FIDOJLMNKGC> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private TaskAwaiter<PFLGPOLCCPC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<FIDOJLMNKGC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB30", Offset = "0x85EB530", VA = "0x1885ECB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x85EDAE0", Offset = "0x85EC4E0", VA = "0x1885EDAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private EGNOIGEDNKF DOGCKMIKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private FKLEENCAODN KACGHKPFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private long FHOIPEIAACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private long HDLFBPMKPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private long OHKJMOJNDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private string DPKNLEFMODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private LKFLNLIEOOH PAINFPACAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private Guid FKDOEDOFGFD;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x85E20D0", Offset = "0x85E0AD0", VA = "0x1885E20D0")]
	public static Task<FKNMGFLNFFM> KGMOPGPHGJI(HKFGPGHMLEK DLDEJAGLCHP, JKKKLGNDOCB OHOKHLNBDDB, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x85E1C40", Offset = "0x85E0640", VA = "0x1885E1C40")]
	[AsyncStateMachine(typeof(KGALEAMBPEE))]
	private Task<FKNMGFLNFFM> IJLCGHNANIM(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x85E1F60", Offset = "0x85E0960", VA = "0x1885E1F60")]
	[AsyncStateMachine(typeof(BJLNIHBCEPE))]
	private Task<FKNMGFLNFFM> ILOGGJOJPGI(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x85E1D90", Offset = "0x85E0790", VA = "0x1885E1D90")]
	[AsyncStateMachine(typeof(OEGJFCCKJLI))]
	private static Task<FKNMGFLNFFM> ILOGGJOJPGI(EJALGCLEMLF FLJMNPJIKOM, FKLEENCAODN KACGHKPFJAB, long FHOIPEIAACP, long HDLFBPMKPAB, long OHKJMOJNDCK, string DPKNLEFMODL, LKFLNLIEOOH PAINFPACAGC, Guid FKDOEDOFGFD, CancellationToken JKPNCAGHEDI, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x85E1C10", Offset = "0x85E0610", VA = "0x1885E1C10")]
	private void CBNPENNMFEM(PFLGPOLCCPC DOMHKNEHBED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct CMCHJJGOKNO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct BJLMKPGMKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public CMCHJJGOKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x85DDBC0", Offset = "0x85DC5C0", VA = "0x1885DDBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x85DE150", Offset = "0x85DCB50", VA = "0x1885DE150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private JFCHLDJHBKP HPGIDELCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private float PAFFEBMNNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private float ONPMEAAJEMB;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x85DFBA0", Offset = "0x85DE5A0", VA = "0x1885DFBA0")]
	public static Task ONEMAFMMFOG(HKFGPGHMLEK DLDEJAGLCHP, JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x85DFA80", Offset = "0x85DE480", VA = "0x1885DFA80")]
	[AsyncStateMachine(typeof(BJLMKPGMKBE))]
	public Task IJLCGHNANIM(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x85DF950", Offset = "0x85DE350", VA = "0x1885DF950")]
	private static void FKOPNMPPMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x85DF7D0", Offset = "0x85DE1D0", VA = "0x1885DF7D0")]
	private void CNCPEOPFOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x85DF710", Offset = "0x85DE110", VA = "0x1885DF710")]
	private static float AGDAHEGLKDC(EJALGCLEMLF FLJMNPJIKOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x85DF930", Offset = "0x85DE330", VA = "0x1885DF930")]
	private static float EKALNPCGCOA()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct ICGMNDENPFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct DMGJNNJKCKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public JJLOAOIEJAJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private CPEALFJADBF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private HKFGPGHMLEK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private BBNEHBBPJIA.NLNAHKAKDPL <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x85E0B20", Offset = "0x85DF520", VA = "0x1885E0B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x85E1310", Offset = "0x85DFD10", VA = "0x1885E1310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct HKABKGBJAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x85E6490", Offset = "0x85E4E90", VA = "0x1885E6490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x85E67C0", Offset = "0x85E51C0", VA = "0x1885E67C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x85E6D60", Offset = "0x85E5760", VA = "0x1885E6D60")]
	[AsyncStateMachine(typeof(DMGJNNJKCKD))]
	public static Task IJLCGHNANIM(JJLOAOIEJAJ GJIGPFFHPEC, JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x85E6EA0", Offset = "0x85E58A0", VA = "0x1885E6EA0")]
	private static Task<OBIDIGOJIIL> IKHKIILMDOH(JJLOAOIEJAJ GJIGPFFHPEC, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x85E6F10", Offset = "0x85E5910", VA = "0x1885E6F10")]
	[AsyncStateMachine(typeof(HKABKGBJAKL))]
	private static Task POJFOPCCEEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct DGNMLMNKFGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct HAMKDFHLBEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public DGNMLMNKFGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x85E4E00", Offset = "0x85E3800", VA = "0x1885E4E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x85E5590", Offset = "0x85E3F90", VA = "0x1885E5590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class BJCCKLJJOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BJCCKLJJOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB40", Offset = "0x85DC540", VA = "0x1885DDB40")]
		internal object ALEACJELCHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct JPHOFHHNCBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public DGNMLMNKFGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x85E8FC0", Offset = "0x85E79C0", VA = "0x1885E8FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x85E9440", Offset = "0x85E7E40", VA = "0x1885E9440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool PBEMHKINDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private CancellationToken JKPNCAGHEDI;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x85DFD40", Offset = "0x85DE740", VA = "0x1885DFD40")]
	public static Task EKAPLMGJDDJ(HKFGPGHMLEK DLDEJAGLCHP, bool PBEMHKINDHO, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken HHJEDBBMJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x85DFDB0", Offset = "0x85DE7B0", VA = "0x1885DFDB0")]
	[AsyncStateMachine(typeof(HAMKDFHLBEH))]
	private Task IJLCGHNANIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x85DFEA0", Offset = "0x85DE8A0", VA = "0x1885DFEA0")]
	[AsyncStateMachine(typeof(JPHOFHHNCBG))]
	private Task JGKAOKJGJPF(bool HGCDIEMGEPF, string HLFANMELOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	private bool KAIDAPEEAPF(bool PBEMHKINDHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct LFMAFNMBPKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct HOEMANMHJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public LFMAFNMBPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x85E6820", Offset = "0x85E5220", VA = "0x1885E6820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x85E6CF0", Offset = "0x85E56F0", VA = "0x1885E6CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class GLKLALMABLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GLKLALMABLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x85E3EF0", Offset = "0x85E28F0", VA = "0x1885E3EF0")]
		internal object ALEACJELCHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct EKIEEKPIPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public LFMAFNMBPKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x85E2320", Offset = "0x85E0D20", VA = "0x1885E2320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x85E27A0", Offset = "0x85E11A0", VA = "0x1885E27A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private PHFPKJEJFEK FDMFHJFHLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x85EC1D0", Offset = "0x85EABD0", VA = "0x1885EC1D0")]
	public static Task<Scene> BJBOGJPOPGH(HKFGPGHMLEK DLDEJAGLCHP, PHFPKJEJFEK KMOHFMKBFEP, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x85EC220", Offset = "0x85EAC20", VA = "0x1885EC220")]
	[AsyncStateMachine(typeof(HOEMANMHJFH))]
	private Task<Scene> IJLCGHNANIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x85EC330", Offset = "0x85EAD30", VA = "0x1885EC330")]
	[AsyncStateMachine(typeof(EKIEEKPIPPF))]
	private Task<Scene> JGKAOKJGJPF(string HLFANMELOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct KPPIBCMDCAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct CAOCMMJKFJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public KPPIBCMDCAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public NBLBPMKGJIE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public JFCHLDJHBKP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<NBLBPMKGJIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x85F62B0", Offset = "0x85F4CB0", VA = "0x1885F62B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x85F6D80", Offset = "0x85F5780", VA = "0x1885F6D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct OLDEAFGMONA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public AsyncTaskMethodBuilder<NBLBPMKGJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public KPPIBCMDCAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public NBLBPMKGJIE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8606D20", Offset = "0x8605720", VA = "0x188606D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8607000", Offset = "0x8605A00", VA = "0x188607000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private readonly JJLOAOIEJAJ GJIGPFFHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private readonly EGNOIGEDNKF DOGCKMIKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private readonly ELLKHNFNFKK MNLLGPIJKIF;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private CPEALFJADBF PKCFNJINFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x69FE170", Offset = "0x69FCB70", VA = "0x1869FE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8602310", Offset = "0x8600D10", VA = "0x188602310")]
	public KPPIBCMDCAJ(JJLOAOIEJAJ GJIGPFFHPEC, EGNOIGEDNKF DOGCKMIKKOD, ELLKHNFNFKK MNLLGPIJKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x8602170", Offset = "0x8600B70", VA = "0x188602170")]
	[AsyncStateMachine(typeof(CAOCMMJKFJI))]
	public Task<NBLBPMKGJIE> JFFAEJIBFKE(NBLBPMKGJIE PFDCMJKCGJK, JFCHLDJHBKP KMLLEPPHFEF, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI, bool KKFHPJJIJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8602010", Offset = "0x8600A10", VA = "0x188602010")]
	[AsyncStateMachine(typeof(OLDEAFGMONA))]
	private Task<NBLBPMKGJIE> DPOJLOMDAFI(JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, NBLBPMKGJIE LOPOEJHIPKN, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8601FE0", Offset = "0x86009E0", VA = "0x188601FE0")]
	private bool CDMLGPANPJE(NBLBPMKGJIE IJFJNPOKOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x86022F0", Offset = "0x8600CF0", VA = "0x1886022F0")]
	private void NLLEOCMFOCP(string JPHCPKKNAGB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct PPMMBGDIBKO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct CHFKKHAMNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public CPEALFJADBF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public BKLLEOOLBCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private EJBJHLMGBBN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private List<(PersistenceView, CEIEJPOFNOJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private (PersistenceView, CEIEJPOFNOJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x85F8590", Offset = "0x85F6F90", VA = "0x1885F8590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x85F8C50", Offset = "0x85F7650", VA = "0x1885F8C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x86084E0", Offset = "0x8606EE0", VA = "0x1886084E0")]
	[AsyncStateMachine(typeof(CHFKKHAMNII))]
	public static Task IJLCGHNANIM(CPEALFJADBF GNLEPFMJLKI, JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct OCNFABPOKBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct NHCBMNIBDPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public CPEALFJADBF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public BKLLEOOLBCA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private OGEHLNKGNIL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private EJBJHLMGBBN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private List<(PersistenceView, CEIEJPOFNOJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private CEIEJPOFNOJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8605BA0", Offset = "0x86045A0", VA = "0x188605BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8606480", Offset = "0x8604E80", VA = "0x188606480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x86064E0", Offset = "0x8604EE0", VA = "0x1886064E0")]
	[AsyncStateMachine(typeof(NHCBMNIBDPG))]
	public static Task IJLCGHNANIM(CPEALFJADBF GNLEPFMJLKI, JFCHLDJHBKP HPGIDELCODH, BKLLEOOLBCA EFBIFFOFADH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public struct DDENPKCLIDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct LDCAFEGJNPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public DDENPKCLIDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public FKKEGKBKICJ.PAADLMLBGCD preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8602370", Offset = "0x8600D70", VA = "0x188602370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x86029E0", Offset = "0x86013E0", VA = "0x1886029E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private long DABJBFIHEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private long BGOMFLGJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private Guid? BCOKPGOMNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private IReadOnlyCollection<CCIEPLLJIFN> EOOAPOKNKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private IReadOnlyCollection<CCIEPLLJIFN> AJMAJNLHJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private CGHCFDNOEBP EINJDHKCHOE;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x85F9140", Offset = "0x85F7B40", VA = "0x1885F9140")]
	public static Task<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> KGMOPGPHGJI(long FHOIPEIAACP, long HDLFBPMKPAB, CGCLGPHBJCJ MHOIOCGAJPP, FKKEGKBKICJ.PAADLMLBGCD BKHFCBGDILK, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x85F8FE0", Offset = "0x85F79E0", VA = "0x1885F8FE0")]
	[AsyncStateMachine(typeof(LDCAFEGJNPG))]
	private Task<KAFLOHEKGBO<NFIEJJOKOOJ, GJIFJLKDAGC>> IJLCGHNANIM(FKKEGKBKICJ.PAADLMLBGCD BKHFCBGDILK, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct BBNEHBBPJIA
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public struct NLNAHKAKDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public List<EHJPCDGEBBK> PJPAHBJBEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public List<CEIEJPOFNOJ> KHNCCHOIOEK;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
		public NLNAHKAKDPL(List<EHJPCDGEBBK> PJPAHBJBEEG, List<CEIEJPOFNOJ> KHNCCHOIOEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class BDLOCOOIABO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public IEnumerable<EHJPCDGEBBK> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BDLOCOOIABO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x85F4980", Offset = "0x85F3380", VA = "0x1885F4980")]
		internal object NFBMLEOMPPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private HKFGPGHMLEK DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private JFCHLDJHBKP HPGIDELCODH;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private EJALGCLEMLF INJOGOILMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x85F48B0", Offset = "0x85F32B0", VA = "0x1885F48B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x85F4850", Offset = "0x85F3250", VA = "0x1885F4850")]
	public static NLNAHKAKDPL IJLCGHNANIM(HKFGPGHMLEK DLDEJAGLCHP, JFCHLDJHBKP HPGIDELCODH)
	{
		return default(NLNAHKAKDPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x85F4600", Offset = "0x85F3000", VA = "0x1885F4600")]
	private NLNAHKAKDPL IJLCGHNANIM()
	{
		return default(NLNAHKAKDPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x85F3E80", Offset = "0x85F2880", VA = "0x1885F3E80")]
	private NLNAHKAKDPL BODEJJEIMBA(BGHEHCDAEKD DJMELIEHAHC, OGEHLNKGNIL DELIMBDIELN)
	{
		return default(NLNAHKAKDPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x85F4430", Offset = "0x85F2E30", VA = "0x1885F4430")]
	private bool HPNDJOAGDHF(IEnumerable<EHJPCDGEBBK> PJPAHBJBEEG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct JGGGFJPEEMP
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class MNFNAAEAKLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public BBNEHBBPJIA.NLNAHKAKDPL instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MNFNAAEAKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8604810", Offset = "0x8603210", VA = "0x188604810")]
		internal object KAAFLKOHNEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class KDLCLDEIGFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KDLCLDEIGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8600AB0", Offset = "0x85FF4B0", VA = "0x188600AB0")]
		internal object HFEKNBIFIOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x85FE230", Offset = "0x85FCC30", VA = "0x1885FE230")]
	public static void IJLCGHNANIM(CPEALFJADBF GNLEPFMJLKI, JFCHLDJHBKP HPGIDELCODH, BBNEHBBPJIA.NLNAHKAKDPL DFKBNDHBEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal class ELLKHNFNFKK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct BKKMCEJAIAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public NBLBPMKGJIE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public JFCHLDJHBKP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A00", Offset = "0x85F3400", VA = "0x1885F4A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x85F5170", Offset = "0x85F3B70", VA = "0x1885F5170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class KCGGHNBMJMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public KCGGHNBMJMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x8608AE0", Offset = "0x86074E0", VA = "0x188608AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x8608DA0", Offset = "0x86077A0", VA = "0x188608DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public JBLIEDANKLD<string>.CKADLEMJOGG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KCGGHNBMJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x86009C0", Offset = "0x85FF3C0", VA = "0x1886009C0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KCCDCIOEKIF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct GOAFOKIINCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private KCGGHNBMJMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x85FC720", Offset = "0x85FB120", VA = "0x1885FC720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x85FCC50", Offset = "0x85FB650", VA = "0x1885FCC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct DJJNJAPNCAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private Dictionary<Guid, List<MPALOKCIKAK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x85F9320", Offset = "0x85F7D20", VA = "0x1885F9320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x85F9930", Offset = "0x85F8330", VA = "0x1885F9930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct OFBFMIEEDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private Dictionary<Guid, List<MPALOKCIKAK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8606620", Offset = "0x8605020", VA = "0x188606620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8606CC0", Offset = "0x86056C0", VA = "0x188606CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class OMELNHIDGEA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			public MPALOKCIKAK handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			public OMELNHIDGEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			private EJBJHLMGBBN <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x8608620", Offset = "0x8607020", VA = "0x188608620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x8608A80", Offset = "0x8607480", VA = "0x188608A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public LAILNAMDFHD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public List<MPALOKCIKAK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OMELNHIDGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x86072C0", Offset = "0x8605CC0", VA = "0x1886072C0")]
		internal object EFMPNLKMCOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x86073B0", Offset = "0x8605DB0", VA = "0x1886073B0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task OFIEHLPEDHC(MPALOKCIKAK handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x86071D0", Offset = "0x8605BD0", VA = "0x1886071D0")]
		internal object CMJPOBJNIII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct GLBPPMCBGMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public LAILNAMDFHD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public List<MPALOKCIKAK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private OMELNHIDGEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x85FC1F0", Offset = "0x85FABF0", VA = "0x1885FC1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x85FC6C0", Offset = "0x85FB0C0", VA = "0x1885FC6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct BLCEMKKMFJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x85F51D0", Offset = "0x85F3BD0", VA = "0x1885F51D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x85F5790", Offset = "0x85F4190", VA = "0x1885F5790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class FIAILAJPCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FIAILAJPCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x85FB190", Offset = "0x85F9B90", VA = "0x1885FB190")]
		internal object FNAJNDENDHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct HHMNKCILGOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public JFCHLDJHBKP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x85FCD20", Offset = "0x85FB720", VA = "0x1885FCD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x85FD1E0", Offset = "0x85FBBE0", VA = "0x1885FD1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class HABDKHFEKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HABDKHFEKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x85FCCB0", Offset = "0x85FB6B0", VA = "0x1885FCCB0")]
		internal object OIHHCKOLJKL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct FLEMJKEOAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public ELLKHNFNFKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private EJBJHLMGBBN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x85FB200", Offset = "0x85F9C00", VA = "0x1885FB200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x85FB830", Offset = "0x85FA230", VA = "0x1885FB830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class ACKOJBOBJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ACKOJBOBJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x85F3A00", Offset = "0x85F2400", VA = "0x1885F3A00")]
		internal object IGFGMKNDNML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private readonly JJLOAOIEJAJ GJIGPFFHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private NBPDAJHEIMO MNLLGPIJKIF;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private CPEALFJADBF PKCFNJINFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1153380", Offset = "0x1151D80", VA = "0x181153380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public ELLKHNFNFKK(JJLOAOIEJAJ GJIGPFFHPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x85FA680", Offset = "0x85F9080", VA = "0x1885FA680")]
	[AsyncStateMachine(typeof(BKKMCEJAIAF))]
	public Task IJLCGHNANIM(NBLBPMKGJIE IFFNNAAMEMJ, JFCHLDJHBKP KMLLEPPHFEF, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x85F9E60", Offset = "0x85F8860", VA = "0x1885F9E60")]
	[AsyncStateMachine(typeof(GOAFOKIINCF))]
	private Task ALMBNJBLLCO(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x85FA7D0", Offset = "0x85F91D0", VA = "0x1885FA7D0")]
	[AsyncStateMachine(typeof(DJJNJAPNCAC))]
	private Task JFGCKKCHOJN(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x85FA540", Offset = "0x85F8F40", VA = "0x1885FA540")]
	[AsyncStateMachine(typeof(OFBFMIEEDEM))]
	private Task ICLNDIDIAIO(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x85FA910", Offset = "0x85F9310", VA = "0x1885FA910")]
	[AsyncStateMachine(typeof(GLBPPMCBGMJ))]
	private Task KAKPIBBIHFP(Guid CANDEHHCANM, List<MPALOKCIKAK> LNFMNOBACOH, LAILNAMDFHD KCIAHHAHHIL, JFCHLDJHBKP HPGIDELCODH, CancellationToken BECBHDDLOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x85FAC30", Offset = "0x85F9630", VA = "0x1885FAC30")]
	[AsyncStateMachine(typeof(BLCEMKKMFJH))]
	private Task PJHEKGMLCFE(JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x85FA400", Offset = "0x85F8E00", VA = "0x1885FA400")]
	[AsyncStateMachine(typeof(HHMNKCILGOF))]
	private Task IBAIONIMONM(Guid KKAGDAIKCCH, JFCHLDJHBKP HPGIDELCODH, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x85F9FA0", Offset = "0x85F89A0", VA = "0x1885F9FA0")]
	[AsyncStateMachine(typeof(FLEMJKEOAEF))]
	private Task BJNJFJNCKCB(Guid KKAGDAIKCCH, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x85FA2F0", Offset = "0x85F8CF0", VA = "0x1885FA2F0")]
	private void GMPOHIBCKEH(Guid KKAGDAIKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x85FA0E0", Offset = "0x85F8AE0", VA = "0x1885FA0E0")]
	private void DPADLCEACAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x85FA190", Offset = "0x85F8B90", VA = "0x1885FA190")]
	public Guid FOLKBDFDNJN(NBLBPMKGJIE FHDHBANKEDI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x85FAA60", Offset = "0x85F9460", VA = "0x1885FAA60")]
	[CompilerGenerated]
	private object LFNCNNJAIAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal struct OLHANLEPFKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct MNGLLJNOADF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public OLHANLEPFKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private IEnumerator<IMPFOMMMKKI> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x86048C0", Offset = "0x86032C0", VA = "0x1886048C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8604F50", Offset = "0x8603950", VA = "0x188604F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private EJALGCLEMLF FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private CancellationToken JKPNCAGHEDI;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x8607070", Offset = "0x8605A70", VA = "0x188607070")]
	public static Task FKDDCOGDBPF(EJALGCLEMLF FLJMNPJIKOM, JBLIEDANKLD<string>.CKADLEMJOGG JNHNJKFGOJB, CancellationToken HHJEDBBMJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x86070E0", Offset = "0x8605AE0", VA = "0x1886070E0")]
	[AsyncStateMachine(typeof(MNGLLJNOADF))]
	private Task IJLCGHNANIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct MCOPGAMEPGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000754")]
	public readonly bool OAHPPLNGPDI;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1DAF0", VA = "0x182B1F0F0")]
	public MCOPGAMEPGG(bool PLCOGNFIJLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct KIPPLECGJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000755")]
	public readonly BGHEHCDAEKD? GDKLAAIHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	public readonly GPGFEFKONNI NEOIDNIANFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	public readonly Guid? PJGFMPKJDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	public readonly IReadOnlyList<Guid> AHAMOPADLMP;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> AHAOOPNGACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8601250", Offset = "0x85FFC50", VA = "0x188601250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> IBKGNILIKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8601270", Offset = "0x85FFC70", VA = "0x188601270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x8601290", Offset = "0x85FFC90", VA = "0x188601290")]
	public KIPPLECGJII(BGHEHCDAEKD? NIAPBNPEIPM, GPGFEFKONNI GKPPIOHOICL, Guid? GJEEKGJKBGO, [Optional] IReadOnlyList<Guid>? IEDPBKMOBFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class JLICKIMDGLN : OBBJEBDKKFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct HNNDIDFCMNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public AsyncTaskMethodBuilder<KIPPLECGJII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public JLICKIMDGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public LOECPFNBOHH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public NACFJGFGJCK roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private EJBJHLMGBBN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x85FD660", Offset = "0x85FC060", VA = "0x1885FD660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x85FDD00", Offset = "0x85FC700", VA = "0x1885FDD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class GGKFOBPOIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GGKFOBPOIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x85FB890", Offset = "0x85FA290", VA = "0x1885FB890")]
		internal object NBIBEOJMIJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct MBDOAAIBOCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public JLICKIMDGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public LOECPFNBOHH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private GGKFOBPOIJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private EJBJHLMGBBN <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private BBKFGDIALBG<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8602BF0", Offset = "0x86015F0", VA = "0x188602BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x86036B0", Offset = "0x86020B0", VA = "0x1886036B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400075A")]
	private static readonly TimeSpan FNNGAMMNCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	private readonly KGNIEBGIABN JDLOIAFGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	private readonly LAOOEKIFEDF EMFKEEIGBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private readonly DJHFAFFDAKG NIFLHJFCLNE;

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x85FFD80", Offset = "0x85FE780", VA = "0x1885FFD80")]
	public JLICKIMDGLN(JJLOAOIEJAJ GJIGPFFHPEC, KGNIEBGIABN JDLOIAFGNCK, LAOOEKIFEDF MHCOJFHMCKG, DJHFAFFDAKG NIFLHJFCLNE, COJJKFBGGKB PMPMPCJHKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x85FFBC0", Offset = "0x85FE5C0", VA = "0x1885FFBC0")]
	[AsyncStateMachine(typeof(HNNDIDFCMNI))]
	public Task<KIPPLECGJII> PGPOMLMDCHO(long HDLFBPMKPAB, NACFJGFGJCK CLGMFHFAPGH, LOECPFNBOHH IPMPKPIBGHH, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x85FED80", Offset = "0x85FD780", VA = "0x1885FED80")]
	[AsyncStateMachine(typeof(MBDOAAIBOCE))]
	private Task GJEGJKGFHNN(LOECPFNBOHH IPMPKPIBGHH, PersistenceView[] MCNLGCPADDM, StringBuilder FEKKMOAFGKP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x85FF5B0", Offset = "0x85FDFB0", VA = "0x1885FF5B0")]
	private KIPPLECGJII NMEAGIAJOKM(long HDLFBPMKPAB, NACFJGFGJCK CLGMFHFAPGH, LOECPFNBOHH IPMPKPIBGHH, IEnumerable<PersistenceView> MCNLGCPADDM, StringBuilder FEKKMOAFGKP)
	{
		return default(KIPPLECGJII);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x85FEBC0", Offset = "0x85FD5C0", VA = "0x1885FEBC0")]
	private BGHEHCDAEKD CLHGEMMFJIH(long HDLFBPMKPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x85FF360", Offset = "0x85FDD60", VA = "0x1885FF360")]
	private void KDPOGMKHFOH(BGHEHCDAEKD OPKACFNMCHG, StringBuilder FEKKMOAFGKP, IEnumerable<PersistenceView> MCNLGCPADDM, [In] AEJBFPJDNNO HEJIOBJPEMA, OHBJFKNEAGF MPCAEJFHCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x85FEEC0", Offset = "0x85FD8C0", VA = "0x1885FEEC0")]
	private void JEBLLNLAJAK(BGHEHCDAEKD OPKACFNMCHG, StringBuilder FEKKMOAFGKP, PersistenceView MMGGIIKGBNM, OHBJFKNEAGF MPCAEJFHCJD, [In] AEJBFPJDNNO HEJIOBJPEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class NDOGPKHMOEO : OBBJEBDKKFK
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class KFKEPBJMHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public JKDEDGGKCKI.NOAHHBKMMMD roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KFKEPBJMHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8600EE0", Offset = "0x85FF8E0", VA = "0x188600EE0")]
		internal object IOFLMAFIFGF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct GIJJFFECEFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public AsyncTaskMethodBuilder<(JKDEDGGKCKI.NOAHHBKMMMD roomDataUpload, JKDEDGGKCKI.NOAHHBKMMMD subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public KIPPLECGJII roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public EJALGCLEMLF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private KFKEPBJMHOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private TaskAwaiter<JKDEDGGKCKI.NOAHHBKMMMD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x85FB900", Offset = "0x85FA300", VA = "0x1885FB900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x85FC180", Offset = "0x85FAB80", VA = "0x1885FC180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct DOEAPPMLEFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public AsyncTaskMethodBuilder<LOKCFGIBPOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public NDOGPKHMOEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public DMEFFBPJOFP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public KIPPLECGJII roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private TaskAwaiter<LOKCFGIBPOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x85F9990", Offset = "0x85F8390", VA = "0x1885F9990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x85F9C30", Offset = "0x85F8630", VA = "0x1885F9C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct MECFKJGPEDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public AsyncTaskMethodBuilder<LOKCFGIBPOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public EJALGCLEMLF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public KIPPLECGJII roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public CHFEIIDNGDD ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public DMEFFBPJOFP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private TaskAwaiter<(JKDEDGGKCKI.NOAHHBKMMMD roomDataUpload, JKDEDGGKCKI.NOAHHBKMMMD subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private TaskAwaiter<LOKCFGIBPOM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x86038E0", Offset = "0x86022E0", VA = "0x1886038E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8603F40", Offset = "0x8602940", VA = "0x188603F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct PHJLDNLKDCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public AsyncTaskMethodBuilder<CIJBIBHOKLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public NDOGPKHMOEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public KIPPLECGJII roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private TaskAwaiter<(JKDEDGGKCKI.NOAHHBKMMMD roomDataUpload, JKDEDGGKCKI.NOAHHBKMMMD subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private TaskAwaiter<CIJBIBHOKLO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8607FB0", Offset = "0x86069B0", VA = "0x188607FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8608470", Offset = "0x8606E70", VA = "0x188608470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class EPLGHLOIBMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public EPLGHLOIBMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private OBIDIGOJIIL <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private TaskAwaiter<CIJBIBHOKLO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private TaskAwaiter<LOKCFGIBPOM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private TaskAwaiter<OBIDIGOJIIL> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x8608E00", Offset = "0x8607800", VA = "0x188608E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x860A010", Offset = "0x8608A10", VA = "0x18860A010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public NDOGPKHMOEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public KIPPLECGJII roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public DMEFFBPJOFP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public MCOPGAMEPGG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EPLGHLOIBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x85FAD70", Offset = "0x85F9770", VA = "0x1885FAD70")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<OBIDIGOJIIL> DNFAMPEAEEH(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct KEMMOIFNMAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public AsyncTaskMethodBuilder<OBIDIGOJIIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public NDOGPKHMOEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public KIPPLECGJII roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public DMEFFBPJOFP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public MCOPGAMEPGG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public JBLIEDANKLD<string>.CKADLEMJOGG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private TaskAwaiter<OBIDIGOJIIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8600B40", Offset = "0x85FF540", VA = "0x188600B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8600E70", Offset = "0x85FF870", VA = "0x188600E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000777")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000778")]
	private static readonly COJJKFBGGKB NLPJGOMOOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000779")]
	private readonly IBDMDBGAGNJ FNBAKEJHDPB;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private HKFGPGHMLEK BGJODJJGMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x85CFFB0", Offset = "0x85CE9B0", VA = "0x1885CFFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x8605B10", Offset = "0x8604510", VA = "0x188605B10")]
	public NDOGPKHMOEO(JJLOAOIEJAJ GJIGPFFHPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x8605930", Offset = "0x8604330", VA = "0x188605930")]
	[AsyncStateMachine(typeof(GIJJFFECEFE))]
	private static Task<(JKDEDGGKCKI.NOAHHBKMMMD, JKDEDGGKCKI.NOAHHBKMMMD)> MLFPPOEJGBO(EJALGCLEMLF FLJMNPJIKOM, KIPPLECGJII CFHMLKEGBGG, long FHOIPEIAACP, long IIHAMPMIGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x8605130", Offset = "0x8603B30", VA = "0x188605130")]
	[AsyncStateMachine(typeof(DOEAPPMLEFF))]
	public Task<LOKCFGIBPOM> KHDJEAKBNMM(int DPBNEMHNHCP, [CanBeNull] DMEFFBPJOFP PBNMCEIBAFO, KIPPLECGJII CFHMLKEGBGG, long FHOIPEIAACP, long IIHAMPMIGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8605430", Offset = "0x8603E30", VA = "0x188605430")]
	public static Task<LOKCFGIBPOM> KHDJEAKBNMM(EJALGCLEMLF FLJMNPJIKOM, int DPBNEMHNHCP, [CanBeNull] DMEFFBPJOFP PBNMCEIBAFO, KIPPLECGJII CFHMLKEGBGG, long FHOIPEIAACP, long IIHAMPMIGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x86052A0", Offset = "0x8603CA0", VA = "0x1886052A0")]
	[AsyncStateMachine(typeof(MECFKJGPEDB))]
	public static Task<LOKCFGIBPOM> KHDJEAKBNMM(EJALGCLEMLF FLJMNPJIKOM, int DPBNEMHNHCP, [CanBeNull] DMEFFBPJOFP PBNMCEIBAFO, KIPPLECGJII CFHMLKEGBGG, long FHOIPEIAACP, long IIHAMPMIGID, CHFEIIDNGDD EFKMKHCOCGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x8604FB0", Offset = "0x86039B0", VA = "0x188604FB0")]
	[AsyncStateMachine(typeof(PHJLDNLKDCC))]
	private Task<CIJBIBHOKLO> IJNAIKNOILF(string DPKNLEFMODL, int DPBNEMHNHCP, KIPPLECGJII CFHMLKEGBGG, long FHOIPEIAACP, long IIHAMPMIGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x8605780", Offset = "0x8604180", VA = "0x188605780")]
	[AsyncStateMachine(typeof(KEMMOIFNMAG))]
	public Task<OBIDIGOJIIL> LPIGLFLGPJB(int DPBNEMHNHCP, DMEFFBPJOFP? PBNMCEIBAFO, KIPPLECGJII CFHMLKEGBGG, long FHOIPEIAACP, long IIHAMPMIGID, MCOPGAMEPGG OCEPADJCNLO, JBLIEDANKLD<string>.CKADLEMJOGG EKKPPJHCMOC, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public abstract class EHPBJKBJNPG<T> where T : EHPBJKBJNPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007BF")]
	internal readonly HKFGPGHMLEK FEJLFNEOIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private int? CHNHLFLCABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	protected readonly Guid NHEGPKBAFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C2")]
	protected readonly KCGEDCCFACD PLOPMIECOKJ;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T IAMPMIABAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x469B3D0", Offset = "0x4699DD0", VA = "0x18469B3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x469B5A0", Offset = "0x4699FA0", VA = "0x18469B5A0")]
	internal EHPBJKBJNPG(HKFGPGHMLEK FONFHOONOKB, KCGEDCCFACD CHMCGCPFKNJ, [Optional] Guid? CFNOFGNKICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x469B4C0", Offset = "0x4699EC0", VA = "0x18469B4C0")]
	private OBIDIGOJIIL PJLMNGNMDPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	protected virtual void GOBGCLBAJFD(OBIDIGOJIIL IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x469B340", Offset = "0x4699D40", VA = "0x18469B340")]
	public T DLHDGCHBNLN(GBDECDHLMJN IKJHHAOIKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x469B430", Offset = "0x4699E30", VA = "0x18469B430")]
	public T PJAFHGLBBJB(int PDCJMMJJDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x469B220", Offset = "0x4699C20", VA = "0x18469B220", Slot = "5")]
	public virtual Task<MKIOIHPBAPC> CPODAMCDKCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class LNIMGIIGMMO : EHPBJKBJNPG<LNIMGIIGMMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C3")]
	private JKKKLGNDOCB MGDBGDNLMCM;

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x8602B20", Offset = "0x8601520", VA = "0x188602B20")]
	internal LNIMGIIGMMO(HKFGPGHMLEK FONFHOONOKB, KCGEDCCFACD CHMCGCPFKNJ, [Optional] Guid? CFNOFGNKICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x77F3360", Offset = "0x77F1D60", VA = "0x1877F3360")]
	public LNIMGIIGMMO BEAFGAAIDCA(JKKKLGNDOCB MGDBGDNLMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x8602A50", Offset = "0x8601450", VA = "0x188602A50", Slot = "4")]
	protected override void GOBGCLBAJFD(OBIDIGOJIIL IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class CEMCGKGJENI : EHPBJKBJNPG<CEMCGKGJENI>
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	internal enum OCOAHLDGDOM
	{
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	private struct HNBOMNJOOFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public AsyncTaskMethodBuilder<MKIOIHPBAPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public CEMCGKGJENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private TaskAwaiter<MKIOIHPBAPC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x85FD240", Offset = "0x85FBC40", VA = "0x1885FD240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x85FD5F0", Offset = "0x85FBFF0", VA = "0x1885FD5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private OCOAHLDGDOM NNGCOELJGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	private string LBNIHDEDHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private DMEFFBPJOFP MGDBGDNLMCM;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x85F8420", Offset = "0x85F6E20", VA = "0x1885F8420")]
	internal CEMCGKGJENI(HKFGPGHMLEK FONFHOONOKB, KCGEDCCFACD CHMCGCPFKNJ, [Optional] Guid? CFNOFGNKICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x85F83A0", Offset = "0x85F6DA0", VA = "0x1885F83A0")]
	public CEMCGKGJENI KKDPBLAGCOP(string NLIGMLKPGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x85F83D0", Offset = "0x85F6DD0", VA = "0x1885F83D0")]
	public CEMCGKGJENI MACBCNEDCFE(bool IPBCGLHLFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x85F8210", Offset = "0x85F6C10", VA = "0x1885F8210")]
	public CEMCGKGJENI DFOGKGBLBNH(bool PFOKKDNJIAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x85F83F0", Offset = "0x85F6DF0", VA = "0x1885F83F0")]
	public CEMCGKGJENI MIDMLFBJLPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x85F8230", Offset = "0x85F6C30", VA = "0x1885F8230", Slot = "4")]
	protected override void GOBGCLBAJFD(OBIDIGOJIIL IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x85F8120", Offset = "0x85F6B20", VA = "0x1885F8120", Slot = "5")]
	[AsyncStateMachine(typeof(HNBOMNJOOFP))]
	public override Task<MKIOIHPBAPC> CPODAMCDKCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x85F80E0", Offset = "0x85F6AE0", VA = "0x1885F80E0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<MKIOIHPBAPC> AALFKEHOKOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal static class MCLJMLBIBPG
{
	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8603710", Offset = "0x8602110", VA = "0x188603710")]
	public static void AJNJLMCAOGM(this MMPJCCHHOBG IIMHDOKFOCH, AKIBJNGPBHA KPBAEDMDFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x8603860", Offset = "0x8602260", VA = "0x188603860")]
	public static void FGLELKMMEME(this AKIBJNGPBHA HDBNMLIMHPI, [Optional] string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class EGELKFDBKBJ
{
	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x85F9DC0", Offset = "0x85F87C0", VA = "0x1885F9DC0")]
	public static LKFLNLIEOOH JHKNFJKDMEO(this CHJFNECFEGP PEBOFPGMBDK)
	{
		return default(LKFLNLIEOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x85F9D10", Offset = "0x85F8710", VA = "0x1885F9D10")]
	public static CHJFNECFEGP DKLGKIEBFFH(this LKFLNLIEOOH NNBNGOLHOPE)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public FEOLABLGAAK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public FEOLABLGAAK HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		private static FEOLABLGAAK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private Dictionary<FEOLABLGAAK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x860A710", Offset = "0x8609110", VA = "0x18860A710")]
		public bool DMLPNNBMJLH(FEOLABLGAAK EPJIFGCCNLC, [Out] ResultConfig DHADAJLMNNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x860A5D0", Offset = "0x8608FD0", VA = "0x18860A5D0")]
		public ResultConfig BOBGBAGNHNB(FEOLABLGAAK CHGJGNFMEJJ, [Optional] HashSet<FEOLABLGAAK> KCJKFLNFHIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x860AD20", Offset = "0x8609720", VA = "0x18860AD20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x860A780", Offset = "0x8609180", VA = "0x18860A780", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public class JKJPOBBHPBH : EANLFKMKDNP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct FCONHAOKABM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public JKJPOBBHPBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x85FAEA0", Offset = "0x85F98A0", VA = "0x1885FAEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x85FB130", Offset = "0x85F9B30", VA = "0x1885FB130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct PEEFLGDAAOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public JBLIEDANKLD<string>.CKADLEMJOGG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public EANLFKMKDNP preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private JBLIEDANKLD<string>.CKADLEMJOGG <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x8607AB0", Offset = "0x86064B0", VA = "0x188607AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8607F50", Offset = "0x8606950", VA = "0x188607F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private readonly FNKMHBAIPLF PKHMHGDEGPB;

	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string CJBNGJHAGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x85FE880", Offset = "0x85FD280", VA = "0x1885FE880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x85FEAE0", Offset = "0x85FD4E0", VA = "0x1885FEAE0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void OFNGDBPMMLB(MHGNCMHMEKD OHEABDJLGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKJPOBBHPBH([CNHMBDDCGKB(null)] FNKMHBAIPLF PKHMHGDEGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x85FE9D0", Offset = "0x85FD3D0", VA = "0x1885FE9D0", Slot = "5")]
	[AsyncStateMachine(typeof(FCONHAOKABM))]
	public Task IJLCGHNANIM(JBLIEDANKLD<string>.CKADLEMJOGG HDFDLAFAIMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x85FE8B0", Offset = "0x85FD2B0", VA = "0x1885FE8B0")]
	[AsyncStateMachine(typeof(PEEFLGDAAOK))]
	private Task EOOFLABIOLB(EANLFKMKDNP GADHCLBNLOG, JBLIEDANKLD<string>.CKADLEMJOGG HDFDLAFAIMP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface FNKMHBAIPLF : EANLFKMKDNP
{
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface EANLFKMKDNP
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string CJBNGJHAGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IJLCGHNANIM(JBLIEDANKLD<string>.CKADLEMJOGG HDFDLAFAIMP, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public static class AMOGCBEGACE
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x85F3A70", Offset = "0x85F2470", VA = "0x1885F3A70")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void FEDJMCICCOK(MHGNCMHMEKD OHEABDJLGDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public interface BAMNMDPIDIE : IEquatable<BAMNMDPIDIE>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime OBHDKGLMCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBLMKCBNAHI();

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHLHPJBGNAG(long FHOIPEIAACP, long HDLFBPMKPAB, [Out] KIPPLECGJII CFHMLKEGBGG);
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal class JPMMNBAAIMA : JOMGIDANJLJ
{
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class ECHFMEAIGJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public GCBBLAMCFIM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ECHFMEAIGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x85F9CA0", Offset = "0x85F86A0", VA = "0x1885F9CA0")]
		internal object LAMFKLEMEKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007ED")]
	private readonly DGGBNOEMILC JDONAGNHIGH;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<BAMNMDPIDIE> PNBAOLEGMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x85FFF50", Offset = "0x85FE950", VA = "0x1885FFF50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x85FFDF0", Offset = "0x85FE7F0", VA = "0x1885FFDF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	[UnityEngine.Scripting.Preserve]
	public JPMMNBAAIMA([CNHMBDDCGKB(null)] DGGBNOEMILC JDONAGNHIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x8600550", Offset = "0x85FEF50", VA = "0x188600550", Slot = "6")]
	public bool OGGDPFKMDDG(long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG, GCBBLAMCFIM JABFDEBGCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0xE3B330", Offset = "0xE39D30", VA = "0x180E3B330")]
	private void AGFAMCDEJJO(BAMNMDPIDIE CIFPMGHKBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x8600850", Offset = "0x85FF250", VA = "0x188600850", Slot = "7")]
	public bool PIMCJKPJPJK(long FHOIPEIAACP, long HDLFBPMKPAB, [Out] BAMNMDPIDIE HGDFIMDKHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x85FFEA0", Offset = "0x85FE8A0", VA = "0x1885FFEA0", Slot = "8")]
	public bool CCBFCBLEIKJ(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, [Out] BAMNMDPIDIE HGDFIMDKHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x8600120", Offset = "0x85FEB20", VA = "0x188600120")]
	private void JLGJMOIDCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8600000", Offset = "0x85FEA00", VA = "0x188600000", Slot = "9")]
	public void GIIPHBLHKPL(long FHOIPEIAACP, long HDLFBPMKPAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal abstract class BLJGODDPHNG : DGGBNOEMILC
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	protected enum NMOLONNMMLL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class CHGCFPLHCAJ : IEnumerable<BAMNMDPIDIE>, IEnumerable, IEnumerator<BAMNMDPIDIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private BAMNMDPIDIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public BLJGODDPHNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private GCBBLAMCFIM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public GCBBLAMCFIM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private BAMNMDPIDIE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public CHGCFPLHCAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x85F8CB0", Offset = "0x85F76B0", VA = "0x1885F8CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x85F8F90", Offset = "0x85F7990", VA = "0x1885F8F90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x85F8EE0", Offset = "0x85F78E0", VA = "0x1885F8EE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BAMNMDPIDIE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x85F8EE0", Offset = "0x85F78E0", VA = "0x1885F8EE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class JHMJALPONHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		public GCBBLAMCFIM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JHMJALPONHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x85FE7E0", Offset = "0x85FD1E0", VA = "0x1885FE7E0")]
		internal object JBHJKKODMHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class BCPEFCBEPEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public BLJGODDPHNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BCPEFCBEPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x85F4900", Offset = "0x85F3300", VA = "0x1885F4900")]
		internal void BIIENFDCAAM(BLAFPLGEPAO.JNKHMHMNCDA ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly object MBLKFOHMFGB;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string PENDBHLCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x85F5EA0", Offset = "0x85F48A0", VA = "0x1885F5EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract HDFOEDDNAHB FGPPICPMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x85F6230", Offset = "0x85F4C30", VA = "0x1885F6230")]
	protected BLJGODDPHNG([CanBeNull] string GFKKDIGHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x85F5CB0", Offset = "0x85F46B0", VA = "0x1885F5CB0", Slot = "5")]
	public bool HPCPBAEIACM(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, [Out] BAMNMDPIDIE CIFPMGHKBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x85F5C20", Offset = "0x85F4620", VA = "0x1885F5C20", Slot = "6")]
	[IteratorStateMachine(typeof(CHGCFPLHCAJ))]
	public IEnumerable<BAMNMDPIDIE> HJODCENFCIF(GCBBLAMCFIM JABFDEBGCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void GPKNIBLINJJ(Stream KPHFHCMPAJO, long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool PKKOAGMCOGO(Stream LKOMOGPNDIC, long FHOIPEIAACP, long HDLFBPMKPAB, DKJMFMDEAJH BFLCDKOJIOG, [Out] KIPPLECGJII CFHMLKEGBGG);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x85F5EB0", Offset = "0x85F48B0", VA = "0x1885F5EB0", Slot = "7")]
	public BAMNMDPIDIE MINMAEPAMNL(long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG, GCBBLAMCFIM JABFDEBGCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo OPEJAINGBIL(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, NMOLONNMMLL EJJPDBJPKBC);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LKAIGHHPBML(GCBBLAMCFIM JABFDEBGCIN, NMOLONNMMLL EJJPDBJPKBC);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x85F57F0", Offset = "0x85F41F0", VA = "0x1885F57F0")]
	protected void CGIECLKHIHD(BLAFPLGEPAO.JNKHMHMNCDA CGJKLECOJFF, string JPHCPKKNAGB, FileInfo ANMGJAKJJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x85F5860", Offset = "0x85F4260", VA = "0x1885F5860")]
	internal bool GNEBJFMDDBJ(FileInfo AHHEKCLDCGH, long FHOIPEIAACP, long HDLFBPMKPAB, [Out] KIPPLECGJII CFHMLKEGBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private void LLDMFHJMDMF(Exception EMKLCNOEBAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class KKIANEOKFKL : BLJGODDPHNG
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override HDFOEDDNAHB FGPPICPMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1386100", Offset = "0x1384B00", VA = "0x181386100", Slot = "8")]
		get
		{
			return default(HDFOEDDNAHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8601FA0", Offset = "0x86009A0", VA = "0x188601FA0")]
	public KKIANEOKFKL([Optional] string GFKKDIGHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8601390", Offset = "0x85FFD90", VA = "0x188601390")]
	private void FIFHEALHEML(GCBBLAMCFIM JABFDEBGCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8601410", Offset = "0x85FFE10", VA = "0x188601410", Slot = "9")]
	internal override void GPKNIBLINJJ(Stream KPHFHCMPAJO, long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x86018B0", Offset = "0x86002B0", VA = "0x1886018B0", Slot = "10")]
	internal override bool PKKOAGMCOGO(Stream LKOMOGPNDIC, long FHOIPEIAACP, long HDLFBPMKPAB, DKJMFMDEAJH BFLCDKOJIOG, [Out] KIPPLECGJII CFHMLKEGBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x86017C0", Offset = "0x86001C0", VA = "0x1886017C0", Slot = "11")]
	protected override FileInfo OPEJAINGBIL(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, NMOLONNMMLL EJJPDBJPKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x86016C0", Offset = "0x86000C0", VA = "0x1886016C0", Slot = "12")]
	protected override DirectoryInfo LKAIGHHPBML(GCBBLAMCFIM JABFDEBGCIN, NMOLONNMMLL EJJPDBJPKBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal sealed class CBODBDFEFCI : BLJGODDPHNG
{
	[Cpp2IlInjected.Token(Token = "0x4000803")]
	private static readonly byte[] KJNEHANBOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000804")]
	private readonly byte[] INMJDLGEABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000805")]
	private readonly byte[] DFBOJPPNBMG;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override HDFOEDDNAHB FGPPICPMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x19183E0", Offset = "0x1916DE0", VA = "0x1819183E0", Slot = "8")]
		get
		{
			return default(HDFOEDDNAHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x85F7FF0", Offset = "0x85F69F0", VA = "0x1885F7FF0")]
	public CBODBDFEFCI([Optional] string GFKKDIGHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x85F6DF0", Offset = "0x85F57F0", VA = "0x1885F6DF0", Slot = "9")]
	internal override void GPKNIBLINJJ(Stream KPHFHCMPAJO, long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x85F7500", Offset = "0x85F5F00", VA = "0x1885F7500", Slot = "10")]
	internal override bool PKKOAGMCOGO(Stream LKOMOGPNDIC, long FHOIPEIAACP, long HDLFBPMKPAB, DKJMFMDEAJH BFLCDKOJIOG, [Out] KIPPLECGJII CFHMLKEGBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x85F7200", Offset = "0x85F5C00", VA = "0x1885F7200")]
	private void HHPFCJOJJEC(byte[] OKLLDHNGOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x85F73D0", Offset = "0x85F5DD0", VA = "0x1885F73D0", Slot = "11")]
	protected override FileInfo OPEJAINGBIL(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, NMOLONNMMLL EJJPDBJPKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x85F72C0", Offset = "0x85F5CC0", VA = "0x1885F72C0", Slot = "12")]
	protected override DirectoryInfo LKAIGHHPBML(GCBBLAMCFIM JABFDEBGCIN, NMOLONNMMLL EJJPDBJPKBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
public enum HDFOEDDNAHB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal class MHOOHBLOABM : DGGBNOEMILC
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	private sealed class ILPBDCAJKDL : IEnumerable<BAMNMDPIDIE>, IEnumerable, IEnumerator<BAMNMDPIDIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private BAMNMDPIDIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public MHOOHBLOABM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private GCBBLAMCFIM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public GCBBLAMCFIM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private HDFOEDDNAHB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IEnumerator<BAMNMDPIDIE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private BAMNMDPIDIE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public ILPBDCAJKDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x85FE1A0", Offset = "0x85FCBA0", VA = "0x1885FE1A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x85FDDC0", Offset = "0x85FC7C0", VA = "0x1885FDDC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x85FDD70", Offset = "0x85FC770", VA = "0x1885FDD70")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE150", Offset = "0x85FCB50", VA = "0x1885FE150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x85FE0A0", Offset = "0x85FCAA0", VA = "0x1885FE0A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BAMNMDPIDIE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x85FE0A0", Offset = "0x85FCAA0", VA = "0x1885FE0A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400080C")]
	private readonly HDFOEDDNAHB[] AGHECDJOHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	private readonly Dictionary<HDFOEDDNAHB, DGGBNOEMILC> AOLNCCIJDNI;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public HDFOEDDNAHB FGPPICPMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x8603FB0", Offset = "0x86029B0", VA = "0x188603FB0", Slot = "4")]
		get
		{
			return default(HDFOEDDNAHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x86044E0", Offset = "0x8602EE0", VA = "0x1886044E0")]
	[UnityEngine.Scripting.Preserve]
	public MHOOHBLOABM(params DGGBNOEMILC[] LANGPJMICJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x86042A0", Offset = "0x8602CA0", VA = "0x1886042A0", Slot = "5")]
	public bool HPCPBAEIACM(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, [Out] BAMNMDPIDIE CIFPMGHKBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x8603FE0", Offset = "0x86029E0", VA = "0x188603FE0")]
	private void BJBBPCKPAJN(int BANDONOHNDO, long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8604210", Offset = "0x8602C10", VA = "0x188604210", Slot = "6")]
	[IteratorStateMachine(typeof(ILPBDCAJKDL))]
	public IEnumerable<BAMNMDPIDIE> HJODCENFCIF(GCBBLAMCFIM JABFDEBGCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x86043F0", Offset = "0x8602DF0", VA = "0x1886043F0", Slot = "7")]
	public BAMNMDPIDIE MINMAEPAMNL(long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG, GCBBLAMCFIM JABFDEBGCIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal static class KHJGMGELJAF
{
	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x8601190", Offset = "0x85FFB90", VA = "0x188601190")]
	internal static byte[] EDLEDAIOBJL(byte[] OKLLDHNGOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x8601110", Offset = "0x85FFB10", VA = "0x188601110")]
	public static void CMJJPFPHHFM(Stream LAIENGFAGKE, byte[] ABMMKPADHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x8600F30", Offset = "0x85FF930", VA = "0x188600F30")]
	public static bool BLEIGDCCBEE(Stream LAIENGFAGKE, long CHBIOPHCEKF, DKJMFMDEAJH EBIBMDLAANI, [Out] byte[] KAJHCNOIMFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal sealed class PAGDEJEFNLF : BAMNMDPIDIE, IEquatable<BAMNMDPIDIE>, IEquatable<PAGDEJEFNLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400081B")]
	private readonly BLJGODDPHNG OPNDGBHBNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400081C")]
	public readonly FileInfo PHMHHNPOLAN;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public HDFOEDDNAHB FGPPICPMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F080", Offset = "0x7E9DA80", VA = "0x187E9F080", Slot = "9")]
		get
		{
			return default(HDFOEDDNAHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime OBHDKGLMCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x86074B0", Offset = "0x8605EB0", VA = "0x1886074B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x86079A0", Offset = "0x86063A0", VA = "0x1886079A0")]
	public PAGDEJEFNLF(BLJGODDPHNG BKNEMJNMLBO, FileInfo AHHEKCLDCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x86078F0", Offset = "0x86062F0", VA = "0x1886078F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x8607540", Offset = "0x8605F40", VA = "0x188607540", Slot = "5")]
	public void CBLMKCBNAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x86078B0", Offset = "0x86062B0", VA = "0x1886078B0", Slot = "6")]
	public bool JHLHPJBGNAG(long FHOIPEIAACP, long HDLFBPMKPAB, [Out] KIPPLECGJII CFHMLKEGBGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x86076F0", Offset = "0x86060F0", VA = "0x1886076F0", Slot = "7")]
	public bool Equals(BAMNMDPIDIE NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8607760", Offset = "0x8606160", VA = "0x188607760", Slot = "8")]
	public bool Equals(PAGDEJEFNLF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8607600", Offset = "0x8606000", VA = "0x188607600", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8607820", Offset = "0x8606220", VA = "0x188607820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
public delegate void DKJMFMDEAJH(BLAFPLGEPAO.JNKHMHMNCDA EIIJODLOJNF, string IJOJGNJMCGP);
[Cpp2IlInjected.Token(Token = "0x20001D3")]
internal interface DGGBNOEMILC
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	HDFOEDDNAHB FGPPICPMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPCPBAEIACM(long FHOIPEIAACP, long HDLFBPMKPAB, GCBBLAMCFIM JABFDEBGCIN, [Out] BAMNMDPIDIE CIFPMGHKBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BAMNMDPIDIE> HJODCENFCIF(GCBBLAMCFIM JABFDEBGCIN);

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BAMNMDPIDIE MINMAEPAMNL(long FHOIPEIAACP, long HDLFBPMKPAB, KIPPLECGJII CFHMLKEGBGG, GCBBLAMCFIM JABFDEBGCIN);
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
